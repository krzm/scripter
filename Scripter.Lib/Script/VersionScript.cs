namespace Scripter;

public class VersionScript : IScript
{
    private readonly IScriptParam scriptParam;

    public string File => $"{scriptParam.ProjectName}.Version.ps1";

    public VersionScript(IScriptParam scriptParam)
    {
        this.scriptParam = scriptParam;
    }

    public string[] GetScript()
    {
        return new string[]
        {
            $"$projectName = \"{scriptParam.ProjectName}\""
            , $"$versionFileName = \"{scriptParam.VersionFileName}\""
            , $"$buildPath = \"{scriptParam.BuildPath}\""
            , $"$scriptPath = \"{scriptParam.ScriptPath}\""
            , $"$repoPath = \"{scriptParam.RepoPath}\""
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