using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Chilano.Iso2God.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
    private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

    public static Settings Default => defaultInstance;

    [DefaultSettingValue("")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public string OutputPath
    {
        get
        {
            return (string)this["OutputPath"];
        }
        set
        {
            this["OutputPath"] = value;
        }
    }

    [DefaultSettingValue("")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public string RebuildPath
    {
        get
        {
            return (string)this["RebuildPath"];
        }
        set
        {
            this["RebuildPath"] = value;
        }
    }

    [DefaultSettingValue("")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public string FtpIP
    {
        get
        {
            return (string)this["FtpIP"];
        }
        set
        {
            this["FtpIP"] = value;
        }
    }

    [DefaultSettingValue("xbox")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public string FtpUser
    {
        get
        {
            return (string)this["FtpUser"];
        }
        set
        {
            this["FtpUser"] = value;
        }
    }

    [DefaultSettingValue("xbox")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public string FtpPass
    {
        get
        {
            return (string)this["FtpPass"];
        }
        set
        {
            this["FtpPass"] = value;
        }
    }

    [DefaultSettingValue("Hdd1/Content/0000000000000000")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public string FtpPath
    {
        get
        {
            return (string)this["FtpPath"];
        }
        set
        {
            this["FtpPath"] = value;
        }
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("21")]
    [UserScopedSetting]
    public string FtpPort
    {
        get
        {
            return (string)this["FtpPort"];
        }
        set
        {
            this["FtpPort"] = value;
        }
    }

    [DefaultSettingValue("True")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public bool AutoRenameMultiDisc
    {
        get
        {
            return (bool)this["AutoRenameMultiDisc"];
        }
        set
        {
            this["AutoRenameMultiDisc"] = value;
        }
    }

    [DefaultSettingValue("False")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public bool FtpUpload
    {
        get
        {
            return (bool)this["FtpUpload"];
        }
        set
        {
            this["FtpUpload"] = value;
        }
    }

    [DefaultSettingValue("0")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public int Format
    {
        get
        {
            return (int)this["Format"];
        }
        set
        {
            this["Format"] = value;
        }
    }

    [DefaultSettingValue("0")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public int Layout
    {
        get
        {
            return (int)this["Layout"];
        }
        set
        {
            this["Layout"] = value;
        }
    }

    [DefaultSettingValue("2")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public int DefaultPadding
    {
        get
        {
            return (int)this["DefaultPadding"];
        }
        set
        {
            this["DefaultPadding"] = value;
        }
    }

    [DefaultSettingValue("False")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public bool AutoBrowse
    {
        get
        {
            return (bool)this["AutoBrowse"];
        }
        set
        {
            this["AutoBrowse"] = value;
        }
    }

    [DefaultSettingValue("False")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public bool TitleDirectory
    {
        get
        {
            return (bool)this["TitleDirectory"];
        }
        set
        {
            this["TitleDirectory"] = value;
        }
    }

    [DefaultSettingValue("800")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public int Width
    {
        get
        {
            return (int)this["Width"];
        }
        set
        {
            this["Width"] = value;
        }
    }

    [DefaultSettingValue("400")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public int Height
    {
        get
        {
            return (int)this["Height"];
        }
        set
        {
            this["Height"] = value;
        }
    }

    [DefaultSettingValue("False")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public bool Maximized
    {
        get
        {
            return (bool)this["Maximized"];
        }
        set
        {
            this["Maximized"] = value;
        }
    }

    [DefaultSettingValue("185,65,35,55,70,100,255")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public string ColumnsWidth
    {
        get
        {
            return (string)this["ColumnsWidth"];
        }
        set
        {
            this["ColumnsWidth"] = value;
        }
    }

    [DefaultSettingValue("False")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public bool DeleteSource
    {
        get
        {
            return (bool)this["DeleteSource"];
        }
        set
        {
            this["DeleteSource"] = value;
        }
    }

    [DefaultSettingValue("False")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public bool DeleteRebuilt
    {
        get
        {
            return (bool)this["DeleteRebuilt"];
        }
        set
        {
            this["DeleteRebuilt"] = value;
        }
    }

    [DefaultSettingValue("False")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public bool DeleteGod
    {
        get
        {
            return (bool)this["DeleteGod"];
        }
        set
        {
            this["DeleteGod"] = value;
        }
    }
}
