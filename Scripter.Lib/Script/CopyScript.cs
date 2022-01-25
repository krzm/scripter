namespace Scripter;

public class CopyScript : IScript
{
    private readonly IScriptParam scriptParam;

    public string File => $"{scriptParam.Project.RepoFolder}.Copy.ps1";

    public CopyScript(IScriptParam scriptParam)
    {
        this.scriptParam = scriptParam;
    }

    public string[] GetScript()
    {
        var repoFolder = scriptParam.Project.RepoFolder;
        var appFolder = scriptParam.Project.AppProjFolder;
        return new string[]
        {
            $"Remove-Item \"{Path.Combine(scriptParam.BuildPath, repoFolder)}\\*\" -Recurse"
            , $"Copy-Item -Path \"{Path.Combine(scriptParam.RepoPath, appFolder)}\\bin\\Release\\net6.0\\publish\\*\" "
                + $"-Destination \"{Path.Combine(scriptParam.BuildPath, repoFolder, appFolder)}\" -Recurse"
        };
    }
}