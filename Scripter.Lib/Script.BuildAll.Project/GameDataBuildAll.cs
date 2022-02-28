namespace Scripter;

public class GameDataBuildAll 
    : ProjBuildAllScript
{
    public override string File => "GameData.BuildAll.ps1";
    public override string Project => "GameData.ConsoleApp";

    public GameDataBuildAll(
        ICodeData appData) 
        : base(appData)
    {
    }
}