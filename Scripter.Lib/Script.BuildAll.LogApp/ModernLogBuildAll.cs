namespace Scripter;

public class ModernLogBuildAll 
    : ProjBuildAllScript
{
    public override string File => "ModernLog.BuildAll.ps1";
    public override string Project => "Log.Modern.ConsoleApp";

    public ModernLogBuildAll(
        IProjectExtractor projectExtractor
        , ICodeData appData) 
            : base(projectExtractor, appData)
    {
    }
}