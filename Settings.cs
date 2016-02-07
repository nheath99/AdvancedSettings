using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdvancedSettings
{
    // This class allows you to handle specific events on the settings class:
    //  The SettingChanging event is raised before a setting's value is changed.
    //  The PropertyChanged event is raised after a setting's value is changed.
    //  The SettingsLoaded event is raised after the setting values are loaded.
    //  The SettingsSaving event is raised before the setting values are saved.
    [SettingsProvider(typeof(CustomSettingsProvider))]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase
    {
        #region Add Settings to this section

        #region Strings

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("Example String Default")]
        [Category("Strings")]
        [Description("An example string")]
        [SaveSettingHistory(true)]
        public string ExampleString
        {
            get { return ((string)(this["ExampleString"])); }
            set { this["ExampleString"] = value; }
        }

        #endregion

        #region Double

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("3.5")]
        [Category("ExampleDouble")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double ExampleDouble
        {
            get { return (double)this["ExampleDouble"]; }
            set { this["ExampleDouble"] = value; }
        }

        #endregion

        #region Int

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("3210")]
        [Category("ExampleInt")]
        [Description("")]
        [SaveSettingHistory(false)]
        public int ExampleInt
        {
            get { return (int)this["ExampleInt"]; }
            set { this["ExampleInt"] = value; }
        }

        #endregion

        #region Bool

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [Category("Bool")]
        [Description("")]
        [global::System.Configuration.DefaultSettingValueAttribute("true")]
        public bool ExampleBool
        {
            get { return ((bool)(this["ExampleBool"])); }
            set { this["ExampleBool"] = value; }
        }

        #endregion

        #region Byte

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("125")]
        [Category("Bytes")]
        [Description("")]
        [SaveSettingHistory(true)]
        public byte ExampleByte
        {
            get { return ((byte)(this["ExampleByte"])); }
            set { this["ExampleByte"] = value; }
        }

        #endregion

        #region Decimal

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("1.34")]
        [Category("Decimals")]
        [Description("")]
        [SaveSettingHistory(true)]
        public decimal ExampleDecimal
        {
            get { return (decimal)this["ExampleDecimal"]; }
            set { this["ExampleDecimal"] = value; }
        }

        #endregion

        #region Short

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("60")]
        [Category("Short Ints")]
        [Description("")]
        [SaveSettingHistory(true)]
        public short ExampleShort
        {
            get { return ((short)(this["ExampleShort"])); }
            set { this["ExampleShort"] = value; }
        }

        #endregion

        #region UShort

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("2800")]
        [Category("Example UShort")]
        [Description("")]
        [SaveSettingHistory(true)]
        public ushort ExampleUShort
        {
            get { return ((ushort)(this["ExampleUShort"])); }
            set { this["ExampleUShort"] = value; }
        }

        #endregion

        #region Connection Strings

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.\\SQLEXPRESS;Initial Catalog=myDB;User ID=myUserId;Password=myPassword")]
        [Category("Database")]
        [Description("")]
        [SaveSettingHistory(true)]
        public string ExampleConnectionString
        {
            get { return ((string)(this["ExampleConnectionString"])); }
            set { this["ExampleConnectionString"] = value; }
        }

        #endregion

        #endregion

        #region XML

        public XDocument GetCurrentSettings()
        {
            XDocument doc = new XDocument();
            XElement root = new XElement("settings");
            root.SetAttributeValue("machineName", Environment.MachineName);
            root.SetAttributeValue("retrieved", DateTime.Now);

            foreach (SettingsProperty setting in Settings.Default.Properties)
            {
                XElement el = new XElement("setting");
                var settingValue = Settings.Default[setting.Name];

                el.SetAttributeValue("name", setting.Name);
                el.SetAttributeValue("value", settingValue);

                el.Add(new XElement("type", setting.PropertyType.FullName));

                bool isDefault;
                var a = setting.DefaultValue.ToString();
                var b = settingValue.ToString();
                if (setting.PropertyType == typeof(bool))
                {
                    isDefault = a.Equals(b, StringComparison.InvariantCultureIgnoreCase);
                }
                else
                {
                    isDefault = a.Equals(b);
                }
                el.Add(new XElement("isDefaultValue", isDefault.ToString()));

                root.Add(el);
            }

            doc.Add(root);
            return doc;
        }

        #endregion

        #region Event Handlers
        public Settings()
        {
            // // To add event handlers for saving and changing settings, uncomment the lines below:
            //
            // this.SettingChanging += this.SettingChangingEventHandler;
            //
            // this.SettingsSaving += this.SettingsSavingEventHandler;
            //
        }

        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e)
        {
            // Add code to handle the SettingChangingEvent event here.
        }

        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Add code to handle the SettingsSaving event here.
        }
        #endregion

        #region Initialization
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));

        public static Settings Default
        {
            get
            {
                return defaultInstance;
            }
        }

        [Browsable(false)]
        public string XmlFileName
        {
            get { return CustomSettingsProvider.XmlFileName; }
            set { CustomSettingsProvider.XmlFileName = value; }
        }

        [Browsable(false)]
        public Action<Exception> ErrorHandler
        {
            get { return CustomSettingsProvider.ErrorHandler; }
            set { CustomSettingsProvider.ErrorHandler = value; }
        }

        [Browsable(false)]
        public Action<string, object> MessageHandler
        {
            get { return CustomSettingsProvider.MessageHandler; }
            set { CustomSettingsProvider.MessageHandler = value; }
        }

        #endregion
    }
}