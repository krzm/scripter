namespace Scripter;

public class AppStarterBuildAll 
    : ProjBuildAllScript
{
    public override string File => "AppStarter.BuildAll.ps1";
    public override string Project => "AppStarter.ConsoleApp";

    public AppStarterBuildAll(
        IProjectExtractor projectExtractor
        , ICodeData appData) 
            : base(projectExtractor, appData)
    {
    }
}