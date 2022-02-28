namespace Scripter;

public class ConsoleInventoryBuildAll 
    : ProjBuildAllScript
{
    public override string File => "ConsoleLibInventory.BuildAll.ps1";
    public override string Project => "Inventory.ConsoleLib.ConsoleApp";
    
    public ConsoleInventoryBuildAll(
        IProjectExtractor projectExtractor
        , ICodeData appData) 
            : base(projectExtractor, appData)
    {
    }
}