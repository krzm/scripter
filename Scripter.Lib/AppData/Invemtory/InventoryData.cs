namespace Scripter;

public abstract class InventoryData
    : ManyRefLibData
{
    protected ProjectDTO? DataLib;

    protected override void SetAllData()
    {
        base.SetAllData();
        SetCommon();
    }

    private void SetCommon()
    {
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        DataLib = Set(
            "inventory-data"
            , "Inventory.Data"
            , new DateOnly()
            , ModelHelper
            , EFCoreHelper);
    }
}