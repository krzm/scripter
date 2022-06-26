using Scripter.Data.Helper;

namespace Scripter.Data;

public abstract class InventoryLibData
    : ManyRefLibData
{
    protected ProjectDTO? DataLib;
    protected ProjectDTO? TableLib;

    protected override void SetAllData()
    {
        base.SetAllData();
        var lastUpd = new DateOnly(2022, 6, 26);
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        DataLib = Set(
            "inventory-data"
            , "Inventory.Data"
            , lastUpd
            , EFCoreHelper
            , DIHelper
            , ModelHelper
            , ConfigWrapper
        );
        ArgumentNullException.ThrowIfNull(DataToTable);
        TableLib = Set(
            "inventory-table"
            , "Inventory.Table"
            , lastUpd
            , DIHelper
            , ModelHelper
            , DataToTable
            , DataLib
        );
    }
}