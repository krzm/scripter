namespace Scripter;

public class VersionScript : IVersionScript
{
    private readonly IScriptVariables scriptVariables;

    public VersionScript(IScriptVariables scriptVariables)
    {
        this.scriptVariables = scriptVariables;
    }

    public string[] GetScript()
    {
        return new string[]
        {
            $"$projectName = \"{scriptVariables.ProjectName}\"{Environment.NewLine}"
            , $"$versionFileName = \"{scriptVariables.VersionFileName}\"{Environment.NewLine}"
            , $"$buildPath = \"{scriptVariables.BuildPath}\"{Environment.NewLine}"
            , $"$scriptPath = \"{scriptVariables.ScriptPath}\"{Environment.NewLine}"
            , $"$repoPath = \"{scriptVariables.RepoPath}\"{Environment.NewLine}"
            , Environment.NewLine
            , $"Set-Location -Path $repoPath{Environment.NewLine}"
            , $"$sh1 = git rev-parse HEAD{Environment.NewLine}"
            , Environment.NewLine
            , $"Set-Location -Path $buildPath{Environment.NewLine}"
            //, $"$versionFileName = $buildPath + \"\\\" + $versionFileName"
        };
    }
}