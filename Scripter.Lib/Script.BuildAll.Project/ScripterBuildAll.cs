namespace Scripter;

public class ScripterBuildAll : ProjBuildAllScript
{
    public override string File => "Scripter.BuildAll.ps1";
    public override string Project => "Scripter";

    public ScripterBuildAll(
        IProjectExtractor projectExtractor
        , ICodeData codeData) 
            : base(projectExtractor, codeData)
    {
    }
}