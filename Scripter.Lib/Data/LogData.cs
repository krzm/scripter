namespace Scripter;

public class LogData : LibData
{
    private ProjectDTO? dataLib;
    private ProjectDTO? modernLib;
    private ProjectDTO? consoleLib;
    private ProjectDTO? wizardLib;
    private ProjectDTO? consoleLibCLIApp;
    private ProjectDTO? modernMDICLIApp;
    private ProjectDTO? modernWizardCLIApp;
    private ProjectDTO? modernCLIApp;

    protected override void SetApps()
    {
        base.SetApps();
        SetCommon();
        SetModern();
        SetModernMDI();
        SetConsoleLib();
        SetModernWizard();
    }

    private void SetCommon()
    {
        dataLib = Set(
            "log-data", "Log.Data"
            , ModelHelper, EFCoreHelper);
    }

    private void SetModern()
    {
        modernLib = Set(
            "log-modern-lib", "Log.Modern.Lib"
            , ModelHelper, EFCoreHelper, DotNetExtension, CLIHelper
            , DataToTable, CRUDCommandHelper, dataLib);
        modernCLIApp = Set(
            "log-modern-consoleapp", "Log.Modern.ConsoleApp"
            , ModelHelper, EFCoreHelper, DataToTable, DIHelper
            , CommandDotNetHelper, CRUDCommandHelper, dataLib, modernLib);
    }

    private void SetModernMDI()
    {
        modernMDICLIApp =  Set(
            "log-modern-mdi-consoleapp", "Log.Modern.MDI.ConsoleApp"
            , ModelHelper, EFCoreHelper, DotNetExtension, CLIHelper
            , DataToTable, DIHelper, CommandDotNetHelper, CRUDCommandHelper
            , dataLib, modernLib);
    }
    
    private void SetConsoleLib()
    {
        consoleLib = Set(
            "log-console-lib", "Log.Console.Lib"
            , CLIHelper, CRUDCommandHelper, CLIWizardHelper, CLIFramework
            , dataLib, modernLib);
        wizardLib = Set(
            "log-wizard-lib", "Log.Wizard.Lib"
            , EFCoreHelper, CLIHelper, CLIReader, CLIWizardHelper
            , dataLib);
        consoleLibCLIApp = Set(
            "log-console-lib-console-app", "Log.ConsoleApp"
            , ModelHelper, EFCoreHelper, DotNetExtension, DataToTable
            , CLIHelper, CLIReader, DIHelper, CRUDCommandHelper
            , CommandDotNetHelper, CLIWizardHelper, CLIFramework, dataLib
            , wizardLib, modernLib, consoleLib);
    }

    private void SetModernWizard()
    {
        modernWizardCLIApp = Set(
            "log-modern-wizard-consoleapp", "Log.Modern.Wizard.ConsoleApp"
            , ModelHelper, EFCoreHelper, DotNetExtension, CLIHelper
            , CLIReader, DataToTable, DIHelper, CommandDotNetHelper
            , CLIWizardHelper, CRUDCommandHelper, dataLib, wizardLib
            , modernLib);
    }
}