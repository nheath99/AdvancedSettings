using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace AdvancedSettings
{
    class CustomSettingsProvider : SettingsProvider
    {
        public override void Initialize(string name, System.Collections.Specialized.NameValueCollection config)
        {
            base.Initialize(this.ApplicationName, config);
        }

        public override string ApplicationName
        {
            get { return System.Reflection.Assembly.GetExecutingAssembly().GetName().Name; }
            set { }
        }

        public static Action<Exception> ErrorHandler { get; set; }
        private void OnError(Exception ex)
        {
            var handler = ErrorHandler;
            if (handler != null)
                handler(ex);
        }

        public static Action<string, object> MessageHandler { get; set; }
        private void OnMessage(string message, object data)
        {
            var handler = MessageHandler;
            if (handler != null)
                handler(message, data);
        }

        private void OnMessage(string message)
        {
            OnMessage(message, null);
        }

        public static string XmlFileName = "settings.xml";

        // XML
        public override SettingsPropertyValueCollection GetPropertyValues(SettingsContext context, SettingsPropertyCollection collection)
        {
            var settings = new SettingsPropertyValueCollection();

            try
            {
                XDocument doc = new XDocument();
                bool hasFile;
                if (string.IsNullOrEmpty(XmlFileName))
                {
                    hasFile = false;
                    OnMessage(string.Format("Cannot find file {0}. Loading default settings instead.", XmlFileName));
                }
                else
                {
                    try
                    {
                        doc = XDocument.Load(XmlFileName);
                        hasFile = true;
                    }
                    catch (FileNotFoundException)
                    {
                        hasFile = false;
                        OnMessage(string.Format("Cannot load file {0}. Loading default settings instead.", XmlFileName));
                    }
                }
                if (hasFile)
                {
                    foreach (SettingsProperty propDef in collection)
                    {
                        var setting = new SettingsPropertyValue(propDef);
                        var allSettings = doc.Element("settings").Elements("setting");
                        var currentSetting = allSettings.SingleOrDefault(x => x.Attribute("name").Value == propDef.Name);
                        var settingValues = currentSetting.Elements("settingValue");
                        if (settingValues.Count() > 0)
                        {
                            var settingElement = settingValues.MaxBy(x => x.Attribute("dateTimeAdded").GetAs<DateTime>());
                            if (settingElement != null)
                            {
                                setting.PropertyValue = Convert.ChangeType(settingElement.Value, Type.GetType(currentSetting.Attribute("type").Value));
                            }
                        }
                        setting.IsDirty = false;
                        settings.Add(setting);
                    }
                }
                else
                {
                    foreach (SettingsProperty propDef in collection)
                    {
                        var setting = new SettingsPropertyValue(propDef);
                        setting.IsDirty = false;
                        settings.Add(setting);
                    }
                }
            }
            catch (Exception ex)
            {
                OnError(ex);
            }
            return settings;
        }

        public override void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection collection)
        {
            try
            {
                if (!string.IsNullOrEmpty(XmlFileName))
                {
                    bool isNewFile;
                    XDocument doc;
                    try
                    {
                        doc = XDocument.Load(XmlFileName);
                        isNewFile = false;
                    }
                    catch (FileNotFoundException)
                    {
                        doc = new XDocument();
                        isNewFile = true;
                        OnMessage(string.Format("Creating new Settings file at: {0}", XmlFileName));
                    }

                    if (isNewFile)
                    {

                        List<XElement> elements = new List<XElement>();
                        foreach (SettingsPropertyValue setting in collection)
                        {
                            // add header elements for each setting
                            XElement el =
                                new XElement("setting",
                                    new XAttribute("dateTimeAdded", DateTime.Now),
                                    new XAttribute("defaultValue", setting.Property.DefaultValue),
                                    new XAttribute("type", setting.Property.PropertyType.FullName),
                                    new XAttribute("name", setting.Name));

                            bool isDefault;
                            var a = setting.PropertyValue.ToString();
                            var b = setting.Property.DefaultValue.ToString();

                            if (setting.Property.PropertyType == typeof(bool))
                            {
                                isDefault = a.Equals(b, StringComparison.InvariantCultureIgnoreCase);
                            }
                            else
                            {
                                isDefault = a.Equals(b);
                            }

                            if (!isDefault)
                            {
                                SaveSettingHistory att = setting.Property.Attributes.ContainsAttribute<SaveSettingHistory>();
                                if (att == null || att.Save)
                                { // if the attribute doesn't exist, or we are asking to save history, add new line below
                                    XElement el1 = new XElement("settingValue");
                                    el1.SetAttributeValue("dateTimeAdded", DateTime.Now);
                                    el1.Value = setting.PropertyValue.ToString();
                                    el.Add(el1);
                                }
                                else
                                { // we have explicitly said not to save history, so change the default value to the current value
                                    el.SetAttributeValue("defaultValue", setting.PropertyValue);
                                }
                            }
                            elements.Add(el);
                        }
                        XElement settingsElement = new XElement("settings", elements);
                        settingsElement.SetAttributeValue("machineName", Environment.MachineName);
                        settingsElement.SetAttributeValue("dateTimeSaved", DateTime.Now);
                        doc.Add(settingsElement);
                    }
                    else
                    {
                        // only add elements where the setting has changed or is not the default value.
                        // a header element should already exist unless it is a new version with new settings, so check if header exists.

                        foreach (SettingsPropertyValue setting in collection)
                        {
                            if (setting.IsDirty)
                            {
                                var settingElement = doc.Element("settings").Elements("setting").SingleOrDefault(x => x.Attribute("name").Value == setting.Name);
                                if (settingElement == null)
                                {
                                    // create a new header
                                    settingElement = new XElement("setting",
                                        new XAttribute("dateTimeAdded", DateTime.Now),
                                        new XAttribute("defaultValue", setting.Property.DefaultValue),
                                        new XAttribute("type", setting.Property.PropertyType.FullName),
                                        new XAttribute("name", setting.Name));
                                }

                                var settingsElements = settingElement.Elements("settingValue");
                                if (settingsElements.Count() == 0)
                                {
                                    // only add if not default
                                    bool isDefault;
                                    var a = setting.PropertyValue.ToString();
                                    var b = setting.Property.DefaultValue.ToString();

                                    if (setting.Property.PropertyType == typeof(bool))
                                    {
                                        isDefault = a.Equals(b, StringComparison.InvariantCultureIgnoreCase);
                                    }
                                    else
                                    {
                                        isDefault = a.Equals(b);
                                    }

                                    if (isDefault)
                                    {
                                        continue;
                                    }
                                }
                                else
                                {
                                    // only add if different from latest setting
                                    var latestSetting = settingsElements.MaxBy(x => x.Attribute("dateTimeAdded").GetAs<DateTime>());  //.Single(x => Convert.ToDateTime(x.Attribute("dateTimeAdded").Value) == maxDateTimeAdded);

                                    var a = setting.PropertyValue.ToString();
                                    var b = latestSetting.Value;

                                    if ((setting.Property.PropertyType == typeof(bool) && a.Equals(b, StringComparison.InvariantCultureIgnoreCase))
                                        || a.Equals(b))
                                    {
                                        continue;
                                    }
                                }

                                SaveSettingHistory att = setting.Property.Attributes.ContainsAttribute<SaveSettingHistory>();

                                if (att == null || att.Save)
                                {
                                    XElement newElement = new XElement("settingValue");
                                    newElement.SetAttributeValue("dateTimeAdded", DateTime.Now);
                                    newElement.Value = setting.PropertyValue.ToString();
                                    settingElement.Add(newElement);
                                }
                                else
                                {
                                    settingElement.SetAttributeValue("defaultValue", setting.PropertyValue);
                                }
                            }
                        }
                    }
                    doc.Element("settings").SetAttributeValue("machineName", Environment.MachineName);
                    doc.Element("settings").SetAttributeValue("dateTimeSaved", DateTime.Now);
                    doc.Save(XmlFileName);
                }
                else
                {
                    throw new FileNotFoundException("Need to specify the XML file name for the settings file (XmlFileName).");
                }
            }
            catch (Exception ex)
            {
                OnError(ex);
            }
        }
    }

    [System.AttributeUsage(System.AttributeTargets.Property, AllowMultiple = false)]
    internal class SaveSettingHistory : System.Attribute
    {
        public bool Save { get; set; }

        public SaveSettingHistory()
        {

        }

        public SaveSettingHistory(bool save)
        {
            this.Save = save;
        }
    }
}
