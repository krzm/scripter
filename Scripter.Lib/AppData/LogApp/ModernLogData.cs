namespace Scripter;

public class ModernLogData 
    : LogLibData
{
    private ProjectDTO? modernCLIApp;

    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        ArgumentNullException.ThrowIfNull(CRUDCommandHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetIoCUnity);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
        ArgumentNullException.ThrowIfNull(Data);
        ArgumentNullException.ThrowIfNull(ModernLibCmds);
        modernCLIApp = Set(
            "log-modern-consoleapp"
            , "Log.Modern.ConsoleApp"
            , true
            , new DateOnly(2022, 3, 22)
            , DIHelper
            , EFCoreHelper
            , ModelHelper
            , CLIHelper
            , DataToTable
            , ConfigWrapper
            , SerilogWrapper
            , CRUDCommandHelper
            , CommandDotNetHelper
            , CommandDotNetIoCUnity
            , CommandDotNetUnityHelper
            , Data
            , ModernLibCmds);
    }
}