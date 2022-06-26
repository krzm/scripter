using Scripter.Data.Helper;

namespace Scripter.Data;

public class ModernLogData 
    : LogLibData
{
    private ProjectDTO? modernCLIApp;

    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(CommandDotNetHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetIoCUnity);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        ArgumentNullException.ThrowIfNull(CRUDCommandHelper);
        ArgumentNullException.ThrowIfNull(Data);
        ArgumentNullException.ThrowIfNull(Tables);
        ArgumentNullException.ThrowIfNull(ModernLibCmds);
        modernCLIApp = Set(
            "log-modern-consoleapp"
            , "Log.Modern.ConsoleApp"
            , isApp: true
            , new DateOnly(2022, 6, 26)
            , EFCoreHelper
            , DIHelper
            , CLIHelper
            , ConfigWrapper
            , ModelHelper
            , DataToTable
            , CommandDotNetHelper
            , CommandDotNetIoCUnity
            , CommandDotNetUnityHelper
            , SerilogWrapper
            , CRUDCommandHelper
            , Data
            , Tables
            , ModernLibCmds);
    }
}