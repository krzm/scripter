namespace Scripter;

public class ModernInventoryBuildAll 
    : ProjectBuildAll
{
    public override string File => "ModernInventory.BuildAll.ps1";
    public override string Project => "Inventory.Modern.ConsoleApp";

    public ModernInventoryBuildAll(
        ICodeData appData) 
        : base(appData)
    {
    }
}