namespace Scripter;

public class ConsoleInventoryData 
    : ModernInventoryData
{
    private ProjectDTO? consoleLib;
    private ProjectDTO? wizardLib;
    private ProjectDTO? consoleLibCLIApp;

    protected override void SetAllData()
    {
        base.SetAllData();
        SetConsole();
    }

    private void SetConsole()
    {
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(CRUDCommandHelper);
        ArgumentNullException.ThrowIfNull(CLIWizardHelper);
        ArgumentNullException.ThrowIfNull(CLIFramework);
        ArgumentNullException.ThrowIfNull(DataLib);
        ArgumentNullException.ThrowIfNull(ModernLib);
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(CLIReader);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(DotNetExtension);
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
        consoleLib = Set(
            "inventory-console-lib", "Inventory.Console.Lib"
            , new DateOnly()
            , CLIHelper, CRUDCommandHelper, CLIWizardHelper, CLIFramework
            , DataLib, ModernLib);
        wizardLib = Set(
            "inventory-wizard-lib", "Inventory.Wizard.Lib"
            , new DateOnly()
            , EFCoreHelper, CLIHelper, CLIReader, CLIWizardHelper
            , DataLib);
        consoleLibCLIApp = Set(
            "inventory-consolelib-consoleapp", "Inventory.ConsoleLib.ConsoleApp"
            , true
            , new DateOnly()
            , ModelHelper, EFCoreHelper, DotNetExtension, DataToTable
            , CLIHelper, CLIReader, DIHelper, CRUDCommandHelper
            , CommandDotNetUnityHelper, CLIWizardHelper, CLIFramework, DataLib
            , wizardLib, ModernLib, consoleLib);
    }
}