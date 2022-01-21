namespace Scripter;

public class CopyScript : IScript
{
    private readonly IScriptParam scriptVariables;

    public string File => $"{scriptVariables.ProjectName}.Copy.ps1";

    public CopyScript(IScriptParam scriptVariables)
    {
        this.scriptVariables = scriptVariables;
    }

    public string[] GetScript()
    {
        return new string[]
        {
            $"Remove-Item \"{Path.Combine(scriptVariables.BuildPath, scriptVariables.ProjectName)}\\*\" -Recurse"
            , $"Copy-Item -Path \"{Path.Combine(scriptVariables.RepoPath, scriptVariables.ProjectName)}\\bin\\Release\\net6.0\\publish\\*\""
        };
    }
}