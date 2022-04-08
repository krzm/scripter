using Unity;

namespace Scripter;

public class InventoryBuildAllSet 
    : ProjBuildAllSetBase
{
    public InventoryBuildAllSet(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void Register()
    {
        RegisterProjBuildAll<ConsoleInventoryData>(
            "ConsoleLibInventory.BuildAll.ps1"
            , "Inventory.ConsoleLib.ConsoleApp");
        RegisterProjBuildAll<ModernInventoryData>(
            "ModernInventory.BuildAll.ps1"
            , "Inventory.Modern.ConsoleApp");
    }
}