namespace Scripter;

public class GameDataBuildAll 
    : ProjectBuildAll
{
    public override string File => "GameData.BuildAll.ps1";
    public override string Project => "GameData.ConsoleApp";

    public GameDataBuildAll(
        ICodeData appData) 
        : base(appData)
    {
    }
}