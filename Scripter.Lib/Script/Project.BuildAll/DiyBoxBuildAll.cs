namespace Scripter;

public class DiyBoxBuildAll 
    : ProjectBuildAll
{
    public override string File => "DiyBox.BuildAll.ps1";
    public override string Project => "DiyBox.ConsoleApp";

    public DiyBoxBuildAll(
        ICodeData appData) 
        : base(appData)
    {
    }
}