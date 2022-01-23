namespace Scripter;

public class CopyScript : IScript
{
    private readonly IScriptParam scriptParam;

    public string File => $"{scriptParam.ProjectName}.Copy.ps1";

    public CopyScript(IScriptParam scriptParam)
    {
        this.scriptParam = scriptParam;
    }

    public string[] GetScript()
    {
        return new string[]
        {
            $"Remove-Item \"{Path.Combine(scriptParam.BuildPath, scriptParam.ProjectName)}\\*\" -Recurse"
            , $"Copy-Item -Path \"{Path.Combine(scriptParam.RepoPath, scriptParam.ProjectName)}\\bin\\Release\\net6.0\\publish\\*\" -Destination \"C:\\kmazanek@gmail.com\\Apps\\{scriptParam.ProjectName}\" -Recurse"
        };
    }
}