﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.18449
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADO0NET.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
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
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.;Initial Catalog=northwind;Integrated Security=True")]
        public string northwindConnectionString {
            get {
                return ((string)(this["northwindConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.;Initial Catalog=AdventureWorks;Integrated Security=True")]
        public string AdventureWorksConnectionString {
            get {
                return ((string)(this["AdventureWorksConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.;Initial Catalog=northwind;Integrated Security=True")]
        public string xxxConnectionString {
            get {
                return ((string)(this["xxxConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\MyAlbum.mdf;Integrat" +
            "ed Security=True;Connect Timeout=30")]
        public string MyAlbumConnectionString {
            get {
                return ((string)(this["MyAlbumConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(localdb)\\v11.0;Initial Catalog=C:\\USERS\\DAVID\\DESKTOP\\ADONET\\ADO.NET" +
            "\\SHARED\\MYALBUM\\DB\\MYALBUM.MDF;Integrated Security=True")]
        public string C__USERS_DAVID_DESKTOP_ADONET_ADO_NET_SHARED_MYALBUM_DB_MYALBUM_MDFConnectionString {
            get {
                return ((string)(this["C__USERS_DAVID_DESKTOP_ADONET_ADO_NET_SHARED_MYALBUM_DB_MYALBUM_MDFConnectionStri" +
                    "ng"]));
            }
        }
    }
}
