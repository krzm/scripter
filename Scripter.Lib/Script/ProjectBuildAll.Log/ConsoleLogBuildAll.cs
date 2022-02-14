namespace Scripter;

public class ConsoleLogBuildAll 
    : ProjectBuildAll
{
    public override string File => "ConsoleLog.BuildAll.ps1";
    public override string Project => "Log.ConsoleApp";
    
    public ConsoleLogBuildAll(
        ICodeData appData) 
        : base(appData)
    {
    }
}