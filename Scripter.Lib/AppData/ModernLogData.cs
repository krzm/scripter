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
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(DotNetExtension);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(CRUDCommandHelper);
        ArgumentNullException.ThrowIfNull(dataLib);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
        ModernLib = Set(
            "log-modern-lib"
            , "Log.Modern.Lib"
            , new DateOnly()
            , ModelHelper
            , EFCoreHelper
            , DotNetExtension
            , CLIHelper
            , DataToTable
            , CRUDCommandHelper
            , dataLib);

        modernCLIApp = Set(
            "log-modern-consoleapp"
            , "Log.Modern.ConsoleApp"
            , true
            , new DateOnly()
            , ModelHelper
            , EFCoreHelper
            , DataToTable
            , DIHelper
            , CommandDotNetUnityHelper
            , CRUDCommandHelper
            , dataLib
            , ModernLib);
    }
}