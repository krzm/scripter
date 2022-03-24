namespace Scripter;

public class ModernInventoryData 
    : InventoryData
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
        ArgumentNullException.ThrowIfNull(DataLib);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
        ModernLib = Set(
            "inventory-modern-lib", "Inventory.Modern.Lib"
            , new DateOnly()
            , ModelHelper, EFCoreHelper, DotNetExtension, CLIHelper
            , DataToTable, CRUDCommandHelper, DataLib);
        modernCLIApp = Set(
            "inventory-modern-consoleapp", "Inventory.Modern.ConsoleApp"
            , true
            , new DateOnly()
            , ModelHelper, EFCoreHelper, DataToTable, DIHelper
            , CommandDotNetUnityHelper, CRUDCommandHelper, DataLib, ModernLib);
    }
}