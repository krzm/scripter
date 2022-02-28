namespace Scripter;

public class DiyBoxBuildAll 
    : ProjBuildAllScript
{
    public override string File => "DiyBox.BuildAll.ps1";
    public override string Project => "DiyBox.ConsoleApp";

    public DiyBoxBuildAll(
        IProjectExtractor projectExtractor
        , ICodeData codeData) 
            : base(projectExtractor, codeData)
    {
    }
}