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

    protected override void SetAllData()
    {
        base.SetAllData();
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
            "log-modern-lib"
            , "Log.Modern.Lib"
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
            , ModelHelper
            , EFCoreHelper
            , DataToTable
            , DIHelper
            , CommandDotNetUnityHelper
            , CRUDCommandHelper
            , dataLib
            , modernLib);
    }

    private void SetModernMDI()
    {
        modernMDICLIApp =  Set(
            "log-modern-mdi-consoleapp", "Log.Modern.MDI.ConsoleApp"
            , true
            , ModelHelper, EFCoreHelper, DotNetExtension, CLIHelper
            , DataToTable, DIHelper, CommandDotNetUnityHelper, CRUDCommandHelper
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
            , true
            , ModelHelper, EFCoreHelper, DotNetExtension, DataToTable
            , CLIHelper, CLIReader, DIHelper, CRUDCommandHelper
            , CommandDotNetUnityHelper, CLIWizardHelper, CLIFramework, dataLib
            , wizardLib, modernLib, consoleLib);
    }

    private void SetModernWizard()
    {
        modernWizardCLIApp = Set(
            "log-modern-wizard-consoleapp", "Log.Modern.Wizard.ConsoleApp"
            , true
            , ModelHelper, EFCoreHelper, DotNetExtension, CLIHelper
            , CLIReader, DataToTable, DIHelper, CommandDotNetUnityHelper
            , CLIWizardHelper, CRUDCommandHelper, dataLib, wizardLib
            , modernLib);
    }
}