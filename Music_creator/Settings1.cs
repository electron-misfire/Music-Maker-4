namespace Music_creator
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Configuration;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    [CompilerGenerated, GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed class Settings1 : ApplicationSettingsBase
    {
        private static Settings1 defaultInstance = ((Settings1) SettingsBase.Synchronized(new Settings1()));

        private void SettingChangingEventHandler(object sender, SettingChangingEventArgs e)
        {
        }

        private void SettingsSavingEventHandler(object sender, CancelEventArgs e)
        {
        }

        public static Settings1 Default
        {
            get
            {
                return defaultInstance;
            }
        }

        [ApplicationScopedSetting, DebuggerNonUserCode, DefaultSettingValue("")]
        public string Setting
        {
            get
            {
                return (string) this["Setting"];
            }
        }
    }
}

