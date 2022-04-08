using Scripter.Inventory;
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
        RegisterProjBuildAll<CliLibAppData>(
            "ConsoleLibInventory.BuildAll.ps1"
            , "Inventory.ConsoleLib.ConsoleApp");
        RegisterProjBuildAll<ModernAppData>(
            "ModernInventory.BuildAll.ps1"
            , "Inventory.Modern.ConsoleApp");
    }
}