namespace Scripter;

public class ModernMDILogBuildAll 
    : ProjBuildAllScript
{
    public override string File => "ModernMDILog.BuildAll.ps1";
    public override string Project => "Log.Modern.MDI.ConsoleApp";

    public ModernMDILogBuildAll(
        ICodeData appData) 
        : base(appData)
    {
    }
}