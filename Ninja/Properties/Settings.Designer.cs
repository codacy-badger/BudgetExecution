﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BudgetExecution.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("data source=\"C:\\Users\\terry\\Documents\\Visual Studio 2017\\Projects\\BudgetExecution" +
            "\\Ninja\\database\\SQLite\\R6.db\"")]
        public string SQLite {
            get {
                return ((string)(this["SQLite"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("DbData Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DbDataDirectory|\\database\\" +
            "SqlServerQuery\\R6.mdf;Integrated Security=True;Connect Timeout=30")]
        public string SqlServerQuery {
            get {
                return ((string)(this["SqlServerQuery"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("data source=\"C:\\Users\\terry\\Documents\\Visual Studio 2017\\Projects\\BudgetExecution" +
            "\\Ninja\\database\\SqlCe\\R6.sdf\"")]
        public string SqlCe {
            get {
                return ((string)(this["SqlCe"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("DbData Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DbDataDirectory|\\database\\" +
            "SqlServerQuery\\R6.mdf;Integrated Security=True;Connect Timeout=30")]
        public string R6ConnectionString {
            get {
                return ((string)(this["R6ConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("DbData Source=\"C:\\Users\\terry\\Documents\\Visual Studio 2017\\Projects\\BudgetExecuti" +
            "on\\Ninja\\database\\SQLite\\R6.db\"")]
        public string SqliteConnectionString {
            get {
                return ((string)(this["SqliteConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.ACE.OLEDB.12.0;DbData Source=|DbDataDirectory|\\R6.accdb")]
        public string OleDb {
            get {
                return ((string)(this["OleDb"]));
            }
        }
    }
}
