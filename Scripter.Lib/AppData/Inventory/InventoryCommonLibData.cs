namespace Scripter;

public abstract class InventoryCommonLibData
    : ManyRefLibData
{
    protected ProjectDTO? DataLib;
    protected ProjectDTO? TableLib;

    protected override void SetAllData()
    {
        base.SetAllData();
        SetCommon();
    }

    private void SetCommon()
    {
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        DataLib = Set(
            "inventory-data"
            , "Inventory.Data"
            , new DateOnly(2022, 4, 8)
            , EFCoreHelper
            , DIHelper
            , ModelHelper
        );
        ArgumentNullException.ThrowIfNull(DataToTable);
        TableLib = Set(
            "inventory-table"
            , "Inventory.Table"
            , new DateOnly(2022, 4, 8)
            , DIHelper
            , ModelHelper
            , DataToTable
            , DataLib
        );
    }
}