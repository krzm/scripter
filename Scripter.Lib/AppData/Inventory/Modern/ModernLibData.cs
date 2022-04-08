namespace Scripter.Inventory;

public class ModernLibData 
    : LibData
{
    protected ProjectDTO? ModernLib;

    protected override void SetAllData()
    {
        base.SetAllData();
        SetModern();
    }

    private void SetModern()
    {
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(DotNetExtension);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(CRUDCommandHelper);
        ArgumentNullException.ThrowIfNull(DataLib);
        ModernLib = Set(
            "inventory-modern-lib"
            , "Inventory.Modern.Lib"
            , new DateOnly(2022, 4, 9)
            , EFCoreHelper
            , DIHelper
            , DotNetExtension
            , CLIHelper
            , ModelHelper
            , DataToTable
            , CRUDCommandHelper
            , DataLib
            );
    }
}