namespace Scripter;

public class ConsoleInventoryBuildAll 
    : ProjectBuildAll
{
    public override string File => "ConsoleLibInventory.BuildAll.ps1";
    public override string Project => "Inventory.ConsoleLib.ConsoleApp";
    
    public ConsoleInventoryBuildAll(
        ICodeData appData) 
        : base(appData)
    {
    }
}