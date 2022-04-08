namespace Scripter.Inventory;

public class CliLibData 
    : LibData
{
    protected ProjectDTO? ConsoleLib;
    protected ProjectDTO? WizardLib;

    protected override void SetAllData()
    {
        base.SetAllData();
        SetConsole();
    }

    private void SetConsole()
    {
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(CRUDCommandHelper);
        ArgumentNullException.ThrowIfNull(CLIWizardHelper);
        ArgumentNullException.ThrowIfNull(CLIFramework);
        ArgumentNullException.ThrowIfNull(DataLib);
        ConsoleLib = Set(
            "inventory-console-lib"
            , "Inventory.Console.Lib"
            , new DateOnly(2022, 4, 8)
            , EFCoreHelper
            , CLIHelper
            , DataToTable
            , CRUDCommandHelper
            , CLIWizardHelper
            , CLIFramework
            , DataLib
            );
        ArgumentNullException.ThrowIfNull(CLIReader);
        WizardLib = Set(
            "inventory-wizard-lib"
            , "Inventory.Wizard.Lib"
            , new DateOnly(2022, 4, 8)
            , EFCoreHelper
            , CLIHelper
            , CLIReader
            , CLIWizardHelper
            , DataLib);
    }
}