namespace Scripter;

public class BuildScript : IScript
{
    private readonly IScriptParam scriptParam;

    public string File => $"{scriptParam.ProjectName}.Build.ps1";

    public BuildScript(IScriptParam scriptParam)
    {
        this.scriptParam = scriptParam;
    }

    public string[] GetScript()
    {
        return new string[]
        {
            $"& \"$PSScriptRoot\\{scriptParam.ProjectName}.Compile.ps1\""
            , $"& \"$PSScriptRoot\\{scriptParam.ProjectName}.Version.ps1\""
            , $"& \"$PSScriptRoot\\{scriptParam.ProjectName}.Copy.ps1\""
        };
    }
}