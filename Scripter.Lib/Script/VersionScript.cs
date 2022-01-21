namespace Scripter;

public class VersionScript : IScript
{
    private readonly IScriptParam scriptVariables;

    public string File => "Version.ps1";

    public VersionScript(IScriptParam scriptVariables)
    {
        this.scriptVariables = scriptVariables;
    }

    public string[] GetScript()
    {
        return new string[]
        {
            $"$projectName = \"{scriptVariables.ProjectName}\""
            , $"$versionFileName = \"{scriptVariables.VersionFileName}\""
            , $"$buildPath = \"{scriptVariables.BuildPath}\""
            , $"$scriptPath = \"{scriptVariables.ScriptPath}\""
            , $"$repoPath = \"{scriptVariables.RepoPath}\""
            , ""
            , $"Set-Location -Path $repoPath"
            , $"$sh1 = git rev-parse HEAD"
            , ""
            , $"Set-Location -Path $buildPath"
            , $"$versionFilePath = $buildPath + \"\\\" + $versionFileName"
            , $"$hashTable = Import-Clixml $versionFilePath"
            , $"$hashTable[$projectName] = $sh1"
            , $"$hashTable | Export-Clixml -Path $versionFilePath"
            , $"Set-Location -Path $scriptPath"
        };
    }
}