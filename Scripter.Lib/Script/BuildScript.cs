namespace Scripter;

public class BuildScript : IScript
{
    private readonly IScriptParam scriptParam;

    public string File => $"{scriptParam.Project.RepoFolder}.Build.ps1";

    public BuildScript(IScriptParam scriptParam)
    {
        this.scriptParam = scriptParam;
    }

    public string[] GetScript()
    {
        var repoFolder = scriptParam.Project.RepoFolder;
        return new string[]
        {
            $"& \"$PSScriptRoot\\{repoFolder}.Compile.ps1\""
            , $"& \"$PSScriptRoot\\{repoFolder}.Version.ps1\""
            , $"& \"$PSScriptRoot\\{repoFolder}.Copy.ps1\""
        };
    }
}