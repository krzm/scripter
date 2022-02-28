namespace Scripter;

public class ConsoleLogBuildAll 
    : ProjBuildAllScript
{
    public override string File => "ConsoleLibLog.BuildAll.ps1";
    public override string Project => "Log.ConsoleApp";
    
    public ConsoleLogBuildAll(
        IProjectExtractor projectExtractor
        , ICodeData appData) 
            : base(projectExtractor, appData)
    {
    }
}