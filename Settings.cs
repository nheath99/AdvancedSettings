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

        #region String

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("CoveyDefaults.xml")]
        [Category("Covey Info")]
        [Description("The filename containing the covey default settings")]
        [SaveSettingHistory(true)]
        public string CoveyDefaultFileName
        {
            get { return ((string)(this["CoveyDefaultFileName"])); }
            set { this["CoveyDefaultFileName"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        [Category("Covey Info")]
        [Description("")]
        [SaveSettingHistory(false)]
        public string Covey_Colour
        {
            get { return ((string)(this["Covey_Colour"])); }
            set { this["Covey_Colour"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\TBDAData")]
        [Category("Data Processing")]
        [Description("")]
        public string Data_CSVFileDirectory
        {
            get { return ((string)(this["Data_CSVFileDirectory"])); }
            set { this["Data_CSVFileDirectory"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("password")]
        [Category("System Settings")]
        [Description("")]
        [SaveSettingHistory(true)]
        public string System_Password
        {
            get { return ((string)(this["System_Password"])); }
            set { this["System_Password"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        [Category("System Settings")]
        [Description("")]
        [SaveSettingHistory(true)]
        public string System_SiteName
        {
            get { return ((string)(this["System_SiteName"])); }
            set { this["System_SiteName"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("MSSQL$SQLEXPRESS")]
        [Category("Database")]
        [Description("")]
        [SaveSettingHistory(true)]
        public string System_DatabaseServiceName
        {
            get { return ((string)(this["System_DatabaseServiceName"])); }
            set { this["System_DatabaseServiceName"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("com1")]
        [Category("Motion Controller")]
        [Description("")]
        [SaveSettingHistory(true)]
        public string Motion_ComPortName
        {
            get { return ((string)(this["Motion_ComPortName"])); }
            set { this["Motion_ComPortName"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        [Category("Sequoia")]
        [Description("")]
        [SaveSettingHistory(true)]
        public string System_SequoiaServerName1
        {
            get { return ((string)(this["System_SequoiaServerName1"])); }
            set { this["System_SequoiaServerName1"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        [Category("Sequoia")]
        [Description("")]
        [SaveSettingHistory(true)]
        public string System_SequoiaServerName2
        {
            get { return ((string)(this["System_SequoiaServerName2"])); }
            set { this["System_SequoiaServerName2"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        [Category("Sequoia")]
        [Description("")]
        [SaveSettingHistory(true)]
        public string System_SequoiaServerName3
        {
            get { return ((string)(this["System_SequoiaServerName3"])); }
            set { this["System_SequoiaServerName3"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        [Category("Sequoia")]
        [Description("")]
        [SaveSettingHistory(true)]
        public string System_SequoiaServerName4
        {
            get { return ((string)(this["System_SequoiaServerName4"])); }
            set { this["System_SequoiaServerName4"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("en")]
        [Category("Language")]
        [Description("")]
        [SaveSettingHistory(true)]
        public string System_LanguageCode
        {
            get { return ((string)(this["System_LanguageCode"])); }
            set { this["System_LanguageCode"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("Dev1")]
        [Category("Peripheral Devices")]
        [Description("")]
        [SaveSettingHistory(true)]
        public string NiDAQ_CardId
        {
            get { return ((string)(this["NiDAQ_CardId"])); }
            set { this["NiDAQ_CardId"] = value; }
        }
        #endregion

        #region Double

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("3.5")]
        [Category("Signal Processing")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double PeakData_NoiseGateV
        {
            get { return (double)this["PeakData_NoiseGateV"]; }
            set { this["PeakData_NoiseGateV"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        [Category("Calibration")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double Optical_CalFactor
        {
            get { return (double)this["Optical_CalFactor"]; }
            set { this["Optical_CalFactor"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        [Category("Signal Processing")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double AnalogIn_MaxPSDVolts
        {
            get { return (double)this["AnalogIn_MaxPSDVolts"]; }
            set { this["AnalogIn_MaxPSDVolts"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("-2")]
        [Category("Signal Processing")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double AnalogIn_MinPSDVolts
        {
            get { return (double)this["AnalogIn_MinPSDVolts"]; }
            set { this["AnalogIn_MinPSDVolts"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        [Category("Calibration")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double Optical_CalFactorGAS
        {
            get { return (double)this["Optical_CalFactorGAS"]; }
            set { this["Optical_CalFactorGAS"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        [Category("Calibration")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double Optical_CalFactorTIN
        {
            get { return (double)this["Optical_CalFactorTIN"]; }
            set { this["Optical_CalFactorTIN"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        [Category("Calibration")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double Optical_CalFactorTX
        {
            get { return (double)this["Optical_CalFactorTX"]; }
            set { this["Optical_CalFactorTX"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        [Category("Calibration")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double Optical_CalFactorANG
        {
            get { return (double)this["Optical_CalFactorANG"]; }
            set { this["Optical_CalFactorANG"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("0.0078")]
        [Category("Signal Processing")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double Encoder_mmpp
        {
            get { return (double)this["Encoder_mmpp"]; }
            set { this["Encoder_mmpp"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("1.512")]
        [Category("Physical Constants")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double Glass_RefractiveIndex
        {
            get { return (double)this["Glass_RefractiveIndex"]; }
            set { this["Glass_RefractiveIndex"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("4.345")]
        [Category("Physical Constants")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double Optical_BeamSeparation
        {
            get { return (double)this["Optical_BeamSeparation"]; }
            set { this["Optical_BeamSeparation"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("79")]
        [Category("Physical Constants")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double Optical_OpticFactor
        {
            get { return (double)this["Optical_OpticFactor"]; }
            set { this["Optical_OpticFactor"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("0.3")]
        [Category("Signal Processing")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double AnalogIn_PauseTriggerV
        {
            get { return (double)this["AnalogIn_PauseTriggerV"]; }
            set { this["AnalogIn_PauseTriggerV"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("20")]
        [Category("Motion Controller")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double Motion_mm_per_Motor_Rev
        {
            get { return (double)this["Motion_mm_per_Motor_Rev"]; }
            set { this["Motion_mm_per_Motor_Rev"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        [Category("Motion Controller")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double Motion_GearRatio
        {
            get { return (double)this["Motion_GearRatio"]; }
            set { this["Motion_GearRatio"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("200")]
        [Category("Motion Controller")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double Motion_Max_mm_per_s
        {
            get { return (double)this["Motion_Max_mm_per_s"]; }
            set { this["Motion_Max_mm_per_s"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("200")]
        [Category("Motion Controller")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double Motion_AccelRamp_mm_per_s2
        {
            get { return (double)this["Motion_AccelRamp_mm_per_s2"]; }
            set { this["Motion_AccelRamp_mm_per_s2"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("40")]
        [Category("Motion Controller")]
        [Description("The speed to go to zero position")]
        [SaveSettingHistory(true)]
        public double Motion_ZeroSpeed_mm_per_s
        {
            get { return (double)this["Motion_ZeroSpeed_mm_per_s"]; }
            set { this["Motion_ZeroSpeed_mm_per_s"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        [Category("Motion Controller")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double Motion_Min_mm_per_s
        {
            get { return (double)this["Motion_Min_mm_per_s"]; }
            set { this["Motion_Min_mm_per_s"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        [Category("Signal Processing")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double AnalogIn_OffsetV
        {
            get { return (double)this["AnalogIn_OffsetV"]; }
            set { this["AnalogIn_OffsetV"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("16")]
        [Category("Motion Controller")]
        [Description("The speed to find home")]
        [SaveSettingHistory(true)]
        public double Motion_FindHomeSpeed_mm_per_s
        {
            get { return (double)this["Motion_FindHomeSpeed_mm_per_s"]; }
            set { this["Motion_FindHomeSpeed_mm_per_s"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        [Category("Motion Controller")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double Motion_StartStopSpeed_mm_per_s
        {
            get { return (double)this["Motion_StartStopSpeed_mm_per_s"]; }
            set { this["Motion_StartStopSpeed_mm_per_s"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("0.4")]
        [Category("Signal Processing")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double Data_IIRFilterPrimaryParameter0
        {
            get { return (double)this["Data_IIRFilterPrimaryParameter0"]; }
            set { this["Data_IIRFilterPrimaryParameter0"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("0.6")]
        [Category("Signal Processing")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double Data_IIRFilterPrimaryParameter1
        {
            get { return (double)this["Data_IIRFilterPrimaryParameter1"]; }
            set { this["Data_IIRFilterPrimaryParameter1"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("0.4")]
        [Category("Signal Processing")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double Data_IIRFilterSecondaryParameter0
        {
            get { return (double)this["Data_IIRFilterSecondaryParameter0"]; }
            set { this["Data_IIRFilterSecondaryParameter0"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("0.5")]
        [Category("Signal Processing")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double Data_IIRFilterSecondaryParameter1
        {
            get { return (double)this["Data_IIRFilterSecondaryParameter1"]; }
            set { this["Data_IIRFilterSecondaryParameter1"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        [Category("Calibration")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double Optical_CalOffsetGAS
        {
            get { return (double)this["Optical_CalOffsetGAS"]; }
            set { this["Optical_CalOffsetGAS"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        [Category("Calibration")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double Optical_CalOffsetTIN
        {
            get { return (double)this["Optical_CalOffsetTIN"]; }
            set { this["Optical_CalOffsetTIN"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        [Category("Calculations")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double Calculations_WavinessMin_wl_mm
        {
            get { return (double)this["Calculations_WavinessMin_wl_mm"]; }
            set { this["Calculations_WavinessMin_wl_mm"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("8")]
        [Category("Calculations")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double Calculations_WavinessMax_wl1_mm
        {
            get { return (double)this["Calculations_WavinessMax_wl1_mm"]; }
            set { this["Calculations_WavinessMax_wl1_mm"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        [Category("Calculations")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double Calculations_WavinessMax_wl2_mm
        {
            get { return (double)this["Calculations_WavinessMax_wl2_mm"]; }
            set { this["Calculations_WavinessMax_wl2_mm"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("191.44")]
        [Category("Calculations")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double Zebra_a
        {
            get { return (double)this["Zebra_a"]; }
            set { this["Zebra_a"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("-0.51")]
        [Category("Calculations")]
        [Description("")]
        [SaveSettingHistory(true)]
        public double Zebra_b
        {
            get { return (double)this["Zebra_b"]; }
            set { this["Zebra_b"] = value; }
        }

        #endregion

        #region Int

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("3210")]
        [Category("Covey Info")]
        [Description("")]
        [SaveSettingHistory(false)]
        public int Covey_NetWidth
        {
            get { return (int)this["Covey_NetWidth"]; }
            set { this["Covey_NetWidth"] = value; }
        }


        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("5000")]
        [Category("Covey Info")]
        [Description("")]
        [SaveSettingHistory(false)]
        public int Covey_FurnaceLoad
        {
            get { return (int)this["Covey_FurnaceLoad"]; }
            set { this["Covey_FurnaceLoad"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        [Category("Covey Info")]
        [Description("")]
        [SaveSettingHistory(false)]
        public int Covey_LineSpeed
        {
            get { return (int)this["Covey_LineSpeed"]; }
            set { this["Covey_LineSpeed"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        [Category("Signal Processing")]
        [Description("")]
        [SaveSettingHistory(true)]
        public int AnalogIn_LineRateHz
        {
            get { return (int)this["AnalogIn_LineRateHz"]; }
            set { this["AnalogIn_LineRateHz"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("25")]
        [Category("Signal Processing")]
        [Description("")]
        [SaveSettingHistory(true)]
        public int PeakData_FinderMinWidth
        {
            get { return (int)this["PeakData_FinderMinWidth"]; }
            set { this["PeakData_FinderMinWidth"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("9600")]
        [Category("Motion Controller")]
        [Description("")]
        [SaveSettingHistory(true)]
        public int Comms_MotorComPortBaud
        {
            get { return (int)this["Comms_MotorComPortBaud"]; }
            set { this["Comms_MotorComPortBaud"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("25")]
        [Category("Motion Controller")]
        [Description("")]
        [SaveSettingHistory(true)]
        public int Motion_Speed_mm_per_s
        {
            get { return (int)this["Motion_Speed_mm_per_s"]; }
            set { this["Motion_Speed_mm_per_s"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("200")]
        [Category("Motion Controller")]
        [Description("")]
        [SaveSettingHistory(true)]
        public int Motion_Pulses_per_Motor_Rev
        {
            get { return (int)this["Motion_Pulses_per_Motor_Rev"]; }
            set { this["Motion_Pulses_per_Motor_Rev"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("200")]
        [Category("Motion Controller")]
        [Description("")]
        [SaveSettingHistory(true)]
        public int Comms_MotorStateMCTimerInterval_ms
        {
            get { return (int)this["Comms_MotorStateMCTimerInterval_ms"]; }
            set { this["Comms_MotorStateMCTimerInterval_ms"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("800")]
        [Category("Motion Controller")]
        [Description("")]
        [SaveSettingHistory(true)]
        public int Motion_ScanDistance_mm
        {
            get { return (int)this["Motion_ScanDistance_mm"]; }
            set { this["Motion_ScanDistance_mm"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("1080")]
        [Category("Motion Controller")]
        [Description("")]
        public int Motion_ScanDistanceMax_mm
        {
            get { return (int)this["Motion_ScanDistanceMax_mm"]; }
            set { this["Motion_ScanDistanceMax_mm"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        [Category("Motion Controller")]
        [Description("")]
        [SaveSettingHistory(true)]
        public int Motion_PulsePerStep
        {
            get { return (int)this["Motion_PulsePerStep"]; }
            set { this["Motion_PulsePerStep"] = value; }
        }

        //[global::System.Configuration.ApplicationScopedSettingAttribute()]
        //[global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        //[global::System.Configuration.DefaultSettingValueAttribute("2500")]
        //[Category("Motion Controller")]
        //[Description("")]
        //[SaveSettingHistory(true)]
        //public int Motion_JogRightPositionmm
        //{
        //    get { return (int)this["Motion_JogRightPositionmm"]; }
        //    set { this["Motion_JogRightPositionmm"] = value; }
        //}

        //[global::System.Configuration.ApplicationScopedSettingAttribute()]
        //[global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        //[global::System.Configuration.DefaultSettingValueAttribute("-2500")]
        //[Category("Motion Controller")]
        //[Description("")]
        //[SaveSettingHistory(true)]
        //public int Motion_JogLeftPositionmm
        //{
        //    get { return (int)this["Motion_JogLeftPositionmm"]; }
        //    set { this["Motion_JogLeftPositionmm"] = value; }
        //}

        //[global::System.Configuration.ApplicationScopedSettingAttribute()]
        //[global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        //[global::System.Configuration.DefaultSettingValueAttribute("10")]
        //[Category("Motion Controller")]
        //[Description("")]
        //[SaveSettingHistory(true)]
        //public int Motion_NotRunningCountMax
        //{
        //    get { return (int)this["Motion_NotRunningCountMax"]; }
        //    set { this["Motion_NotRunningCountMax"] = value; }
        //}

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("1000")]
        [Category("Motion Controller")]
        [Description("")]
        [SaveSettingHistory(true)]
        public int Encoder_SimulateHz
        {
            get { return (int)this["Encoder_SimulateHz"]; }
            set { this["Encoder_SimulateHz"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        [Category("Signal Processing")]
        [Description("")]
        [SaveSettingHistory(true)]
        public int AnalogIn_GlassSensorOffset_mm
        {
            get { return (int)this["AnalogIn_GlassSensorOffset_mm"]; }
            set { this["AnalogIn_GlassSensorOffset_mm"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        [Category("Signal Processing")]
        [Description("")]
        [SaveSettingHistory(true)]
        public int AnalogIn_MaxBadPeakDataCount
        {
            get { return (int)this["AnalogIn_MaxBadPeakDataCount"]; }
            set { this["AnalogIn_MaxBadPeakDataCount"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("750")]
        [Category("Signal Processing")]
        [Description()]
        [SaveSettingHistory(true)]
        public int ChopperMotor_TargetSpeed_rpm
        {
            get { return (int)this["ChopperMotor_TargetSpeed_rpm"]; }
            set { this["ChopperMotor_TargetSpeed_rpm"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("11")]
        [Category("Language")]
        [Description("")]
        [SaveSettingHistory(true)]
        public int System_LanguageID
        {
            get { return (int)this["System_LanguageID"]; }
            set { this["System_LanguageID"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        [Category("System Settings")]
        [Description("")]
        [SaveSettingHistory(true)]
        public int System_SiteIndex
        {
            get { return (int)this["System_SiteIndex"]; }
            set { this["System_SiteIndex"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("40")]
        [Category("Data Processing")]
        [Description("")]
        [SaveSettingHistory(false)]
        public int Data_LeftMargin
        {
            get { return (int)this["Data_LeftMargin"]; }
            set { this["Data_LeftMargin"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("40")]
        [Category("Data Processing")]
        [Description("")]
        [SaveSettingHistory(false)]
        public int Data_RightMargin
        {
            get { return (int)this["Data_RightMargin"]; }
            set { this["Data_RightMargin"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("5000")]
        [Category("Data Processing")]
        [Description("")]
        [SaveSettingHistory(true)]
        public int Data_MaxNumberSamples
        {
            get { return (int)this["Data_MaxNumberSamples"]; }
            set { this["Data_MaxNumberSamples"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        [Category("Motion Controller")]
        [Description("")]
        [SaveSettingHistory(true)]
        public int Motor_JogReturnSpeed_mm_per_s
        {
            get { return (int)this["Motor_JogReturnSpeed_mm_per_s"]; }
            set { this["Motor_JogReturnSpeed_mm_per_s"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        [Category("Covey Info")]
        [Description("")]
        [SaveSettingHistory(true)]
        public int Covey_CrosslineSamples
        {
            get { return (int)this["Covey_CrosslineSamples"]; }
            set { this["Covey_CrosslineSamples"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("20")]
        [Category("System Settings")]
        [Description("")]
        [SaveSettingHistory(true)]
        public int System_LaserWarmUpSeconds
        {
            get { return (int)this["System_LaserWarmUpSeconds"]; }
            set { this["System_LaserWarmUpSeconds"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("61")]
        [Category("Calculations")]
        [Description("")]
        [SaveSettingHistory(true)]
        public int Calculations_WavinessGaussianTerms
        {
            get { return (int)this["Calculations_WavinessGaussianTerms"]; }
            set { this["Calculations_WavinessGaussianTerms"] = value; }
        }

        #endregion

        #region Bool

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [Category("System Settings")]
        [Description("")]
        [global::System.Configuration.DefaultSettingValueAttribute("false")]
        public bool System_DisableCovey
        {
            get { return ((bool)(this["System_DisableCovey"])); }
            set { this["System_DisableCovey"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("false")]
        [Category("Signal Processing")]
        [Description("")]
        public bool PeakData_CalbackTimeMsgEnable
        {
            get { return ((bool)(this["PeakData_CalbackTimeMsgEnable"])); }
            set { this["PeakData_CalbackTimeMsgEnable"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("true")]
        [Category("Graph")]
        [Description("")]
        public bool Data_ViewAnglePlots
        {
            get { return ((bool)(this["Data_ViewAnglePlots"])); }
            set { this["Data_ViewAnglePlots"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("false")]
        [Category("System Settings")]
        [Description("")]
        [SaveSettingHistory(true)]
        public bool System_PasswordEnabled
        {
            get { return ((bool)(this["System_PasswordEnabled"])); }
            set { this["System_PasswordEnabled"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("false")]
        [Category("Data Processing")]
        [Description("")]
        public bool Report_CSVSavePSDVoltsData
        {
            get { return ((bool)(this["Report_CSVSavePSDVoltsData"])); }
            set { this["Report_CSVSavePSDVoltsData"] = value; }
        }


        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("false")]
        [Category("Covey Settings")]
        [Description("")]
        [SaveSettingHistory(false)]
        public bool CoveyDetails_ShowAdditionalDetails
        {
            get { return ((bool)(this["CoveyDetails_ShowAdditionalDetails"])); }
            set { this["CoveyDetails_ShowAdditionalDetails"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("false")]
        [Category("Covey Info")]
        [Description("")]
        [SaveSettingHistory(false)]
        public bool SendDataToSequoiaOnCompleteCovey
        {
            get { return ((bool)(this["SendDataToSequoiaOnCompleteCovey"])); }
            set { this["SendDataToSequoiaOnCompleteCovey"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("false")]
        [Category("Covey Info")]
        [Description("")]
        [SaveSettingHistory(false)]
        public bool Data_LowTransmissionGlass
        {
            get { return ((bool)(this["Data_LowTransmissionGlass"])); }
            set { this["Data_LowTransmissionGlass"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("false")]
        [Category("Covey Settings")]
        [Description("")]
        public bool CoveyInfo_DisplayLowTransmission
        {
            get { return ((bool)(this["CoveyInfo_DisplayLowTransmission"])); }
            set { this["CoveyInfo_DisplayLowTransmission"] = value; }
        }


        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("true")]
        [Category("Signal Processing")]
        [Description("")]
        [SaveSettingHistory(true)]
        public bool AnalogIn_PauseTriggerEnabled
        {
            get { return ((bool)(this["AnalogIn_PauseTriggerEnabled"])); }
            set { this["AnalogIn_PauseTriggerEnabled"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("false")]
        [Category("Motion Controller")]
        [Description("")]
        [SaveSettingHistory(true)]
        public bool Motion_Reversed
        {
            get { return ((bool)(this["Motion_Reversed"])); }
            set { this["Motion_Reversed"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("false")]
        [Category("Motion Controller")]
        [Description("")]
        [SaveSettingHistory(true)]
        public bool DEBUG_TraverseDisable
        {
            get { return ((bool)(this["DEBUG_TraverseDisable"])); }
            set { this["DEBUG_TraverseDisable"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("true")]
        [Category("Reporting")]
        [Description("")]
        [SaveSettingHistory(true)]
        public bool Report_ShowHiddenFields
        {
            get { return ((bool)(this["Report_ShowHiddenFields"])); }
            set { this["Report_ShowHiddenFields"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("false")]
        [Category("Graph")]
        [Description("")]
        [SaveSettingHistory(true)]
        public bool Report_GraphReversePowers
        {
            get { return ((bool)(this["Report_GraphReversePowers"])); }
            set { this["Report_GraphReversePowers"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("true")]
        [Category("Covey Info")]
        [Description("")]
        [SaveSettingHistory(true)]
        public bool Covey_Filtering
        {
            get { return ((bool)(this["Covey_Filtering"])); }
            set { this["Covey_Filtering"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("false")]
        [Category("System Settings")]
        [Description("")]
        [SaveSettingHistory(false)]
        public bool Debug_PauseOnStart
        {
            get { return ((bool)(this["Debug_PauseOnStart"])); }
            set { this["Debug_PauseOnStart"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("true")]
        [Category("Calculations")]
        [Description("")]
        [SaveSettingHistory(true)]
        public bool Calculations_Waviness
        {
            get { return ((bool)(this["Calculations_Waviness"])); }
            set { this["Calculations_Waviness"] = value; }
        }

        #endregion

        #region Byte

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("125")]
        [Category("Motion Controller")]
        [Description("")]
        [SaveSettingHistory(true)]
        public byte Motion_ModbusAddress
        {
            get { return ((byte)(this["Motion_ModbusAddress"])); }
            set { this["Motion_ModbusAddress"] = value; }
        }

        #endregion

        #region Decimal

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("1.34")]
        [Category("Calculations")]
        [Description("")]
        [SaveSettingHistory(true)]
        public decimal Calculations_SDsToAdd
        {
            get { return (decimal)this["Calculations_SDsToAdd"]; }
            set { this["Calculations_SDsToAdd"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("2.1")]
        [Category("Covey Info")]
        [Description("")]
        public decimal Covey_GlassThickness
        {
            get { return (decimal)this["Covey_GlassThickness"]; }
            set { this["Covey_GlassThickness"] = value; }
        }

        #endregion

        #region Short

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("60")]
        [Category("Data Processing")]
        [Description("")]
        [SaveSettingHistory(true)]
        public short Data_SlideAverageNumberPoints
        {
            get { return ((short)(this["Data_SlideAverageNumberPoints"])); }
            set { this["Data_SlideAverageNumberPoints"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        [Category("Data Processing")]
        [Description("")]
        [SaveSettingHistory(true)]
        public short Data_SlideAverageOffset
        {
            get { return ((short)(this["Data_SlideAverageOffset"])); }
            set { this["Data_SlideAverageOffset"] = value; }
        }

        #endregion

        #region UShort

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("2800")]
        [Category("Motion Controller")]
        [Description("")]
        [SaveSettingHistory(true)]
        public ushort Motor_NominalCurrent
        {
            get { return ((ushort)(this["Motor_NominalCurrent"])); }
            set { this["Motor_NominalCurrent"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("1500")]
        [Category("Motion Controller")]
        [Description("")]
        [SaveSettingHistory(true)]
        public ushort Motor_ReducedCurrent
        {
            get { return ((ushort)(this["Motor_ReducedCurrent"])); }
            set { this["Motor_ReducedCurrent"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("3500")]
        [Category("Motion Controller")]
        [Description("")]
        [SaveSettingHistory(true)]
        public ushort Motor_BoostCurrent
        {
            get { return ((ushort)(this["Motor_BoostCurrent"])); }
            set { this["Motor_BoostCurrent"] = value; }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.DefaultSettingValueAttribute("768")]
        [Category("Motion Controller")]
        [Description("")]
        [SaveSettingHistory(true)]
        public ushort Motion_PhaseAdvanceGain
        {
            get { return ((ushort)(this["Motion_PhaseAdvanceGain"])); }
            set { this["Motion_PhaseAdvanceGain"] = value; }
        }

        #endregion

        #region Connection Strings

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(CustomSettingsProvider))]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.\\SQLEXPRESS;Initial Catalog=TBDA;User ID=tbdaapp;Password=tbdaapp")]
        [Category("Database")]
        [Description("")]
        [SaveSettingHistory(true)]
        public string Report_DBTBDAConnectionString
        {
            get { return ((string)(this["Report_DBTBDAConnectionString"])); }
            set { this["Report_DBTBDAConnectionString"] = value; }
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