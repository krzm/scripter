namespace Scripter;

public class ModernLogBuildAll 
    : ProjBuildAllScript
{
    public override string File => "ModernLog.BuildAll.ps1";
    public override string Project => "Log.Modern.ConsoleApp";

    public ModernLogBuildAll(
        ICodeData appData) 
        : base(appData)
    {
    }
}