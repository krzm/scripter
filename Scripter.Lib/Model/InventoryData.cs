namespace Scripter;

public class InventoryData : LibData
{
    private ProjectDTO? dataLib;
    private ProjectDTO? modernLib;
    private ProjectDTO? consoleLib;
    private ProjectDTO? wizardLib;
    private ProjectDTO? modernCLIApp;
    private ProjectDTO? consoleLibCLIApp;

    protected override void SetApps()
    {
        base.SetApps();
        SetCommon();
        SetModern();
        SetConsole();
        SetModernWizard();
    }

    private void SetCommon()
    {
        dataLib = Set(
            "inventory-data", "Inventory.Data"
            , ModelHelper, EFCoreHelper);
    }

    private void SetModern()
    {
        modernLib = Set(
            "inventory-modern-lib", "Inventory.Modern.Lib"
            , ModelHelper, EFCoreHelper, DotNetExtension, CLIHelper
            , DataToTable, CRUDCommandHelper, dataLib);
        modernCLIApp = Set(
            "inventory-modern-consoleapp", "Inventory.Modern.ConsoleApp"
            , ModelHelper, EFCoreHelper, DataToTable, DIHelper
            , CommandDotNetHelper, CRUDCommandHelper, dataLib, modernLib);
    }

    private void SetConsole()
    {
        consoleLib = Set(
            "inventory-console-lib", "Inventory.Console.Lib"
            , CLIHelper, CRUDCommandHelper, CLIWizardHelper, CLIFramework
            , dataLib, modernLib);
        wizardLib = Set(
            "inventory-wizard-lib", "Inventory.Wizard.Lib"
            , EFCoreHelper, CLIHelper, CLIReader, CLIWizardHelper
            , dataLib);
        consoleLibCLIApp = Set(
            "inventory-consolelib-consoleapp", "Inventory.ConsoleLib.ConsoleApp"
            , ModelHelper, EFCoreHelper, DotNetExtension, DataToTable
            , CLIHelper, CLIReader, DIHelper, CRUDCommandHelper
            , CommandDotNetHelper, CLIWizardHelper, CLIFramework, dataLib
            , wizardLib, modernLib, consoleLib);
    }

    private void SetModernWizard()
    {
        
    }
}