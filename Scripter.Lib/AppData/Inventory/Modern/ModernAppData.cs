namespace Scripter.Inventory;

public class ModernAppData 
    : ModernLibData
{
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
        modernCLIApp = Set(
            "inventory-modern-consoleapp"
            , "Inventory.Modern.ConsoleApp"
            , true
            , new DateOnly()
            , ModelHelper
            , EFCoreHelper
            , DataToTable
            , DIHelper
            , CommandDotNetUnityHelper
            , CRUDCommandHelper
            , DataLib
            , ModernLib);
    }
}