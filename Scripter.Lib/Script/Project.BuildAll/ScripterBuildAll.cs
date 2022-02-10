namespace Scripter;

public class ScripterBuildAll : ProjectBuildAll
{
    public override string File => "Scripter.BuildAll.ps1";
    public override string Project => "Scripter";

    public ScripterBuildAll(
        ICodeData appData) 
        : base(appData)
    {
    }
}