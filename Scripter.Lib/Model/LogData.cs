namespace Scripter;

public class LogData : AppData
{
    protected override void SetApps()
    {
        base.SetApps();
        SetLog();
        SetModernLog();
        SetConsoleLog();
        SetModernLogWizard();
    }

    private void SetLog()
    {
        LogData = Set(
            "log-data", "Log.Data"
            , ModelHelper, EFCoreHelper);
    }

    private void SetConsoleLog()
    {
        LogConsoleLib = Set("log-console-lib", "Log.Console.Lib"
            , CLIHelper, CRUDCommandHelper, CLIWizardHelper, CLIFramework
            , LogData, LogModernLib);
    }

    private void SetModernLogWizard()
    {
        LogWizardLib = Set(
            "log-wizard-lib", "Log.Wizard.Lib"
            , EFCoreHelper, CLIHelper, CLIReader, LogData
            , CLIWizardHelper);
        LogModernWizard = Set(
            "log-modern-wizard-consoleapp", "Log.Modern.Wizard.ConsoleApp"
            , ModelHelper, EFCoreHelper, DotNetExtension, CLIHelper
            , CLIReader, DataToTable, DIHelper, CommandDotNetHelper
            , CLIWizardHelper, CRUDCommandHelper, LogData, LogWizardLib
            , LogModernLib);
    }
    
    private void SetModernLog()
    {
        LogModernLib = Set(
            "log-modern-lib", "Log.Modern.Lib"
            , ModelHelper, EFCoreHelper, DotNetExtension, CLIHelper
            , DataToTable, CRUDCommandHelper, LogData);
        LogModernConsoleApp = Set(
            "log-modern-consoleapp", "Log.Modern.ConsoleApp"
            , ModelHelper, EFCoreHelper, DataToTable, DIHelper
            , CommandDotNetHelper, CRUDCommandHelper, LogData, LogModernLib);
    }
}