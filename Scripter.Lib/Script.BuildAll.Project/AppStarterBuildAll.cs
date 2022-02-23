namespace Scripter;

public class AppStarterBuildAll 
    : ProjectBuildAll
{
    public override string File => "AppStarter.BuildAll.ps1";
    public override string Project => "AppStarter.ConsoleApp";

    public AppStarterBuildAll(
        ICodeData appData) 
        : base(appData)
    {
    }
}