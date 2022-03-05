namespace Scripter;

public class InventoryData : LibData
{
    private ProjectDTO? dataLib;
    private ProjectDTO? modernLib;
    private ProjectDTO? consoleLib;
    private ProjectDTO? wizardLib;
    private ProjectDTO? modernCLIApp;
    private ProjectDTO? consoleLibCLIApp;

    protected override void SetAllData()
    {
        base.SetAllData();
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
            , true
            , ModelHelper, EFCoreHelper, DataToTable, DIHelper
            , CommandDotNetUnityHelper, CRUDCommandHelper, dataLib, modernLib);
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
            , true
            , ModelHelper, EFCoreHelper, DotNetExtension, DataToTable
            , CLIHelper, CLIReader, DIHelper, CRUDCommandHelper
            , CommandDotNetUnityHelper, CLIWizardHelper, CLIFramework, dataLib
            , wizardLib, modernLib, consoleLib);
    }

    private void SetModernWizard()
    {
        
    }
}