namespace Scripter;

public class ModernLogData 
    : LogData
{
    protected ProjectDTO? ModernLib;
    private ProjectDTO? modernCLIApp;

    protected override void SetAllData()
    {
        base.SetAllData();
        SetModern();
    }

    private void SetModern()
    {
        ArgumentNullException.ThrowIfNull(DotNetExtension);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(CRUDCommandHelper);
        ArgumentNullException.ThrowIfNull(DataLib);
        ModernLib = Set(
            "log-modern-lib"
            , "Log.Modern.Lib"
            , new DateOnly(2022, 3, 22)
            , DotNetExtension
            , DIHelper
            , EFCoreHelper
            , ModelHelper
            , CLIHelper
            , DataToTable
            , CRUDCommandHelper
            , DataLib);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        ArgumentNullException.ThrowIfNull(CommandDotNetHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetIoCUnity);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
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
            , DataLib
            , ModernLib);
    }
}