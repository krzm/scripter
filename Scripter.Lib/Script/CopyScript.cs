namespace Scripter;

public class CopyScript : IScript
{
    private readonly IScriptParam scriptParam;

    public string File => $"{scriptParam.Project.AppProjFolder}.Copy.ps1";

    public CopyScript(IScriptParam scriptParam)
    {
        this.scriptParam = scriptParam;
    }

    public string[] GetScript()
    {
        var repoFolder = scriptParam.Project.RepoFolder;
        var appFolder = scriptParam.Project.AppProjFolder;
        var buildPath = scriptParam.BuildPath;
        var repoPath = scriptParam.RepoPath;
        var repoBuildPath = Path.Combine(buildPath, repoFolder);
        var appProjPath = Path.Combine(repoPath, appFolder);
        var appProjBuildPath = Path.Combine(buildPath, repoFolder, appFolder);
        return new string[]
        {
            $"$path = \"{repoBuildPath}\""
            , "if (-not (Test-Path $path))"
            , "{"
            , $"New-Item -Path \"{buildPath}\" -Name \"{repoFolder}\" -ItemType \"directory\""
            , "}"
            , $"$path = \"{appProjBuildPath}\""
            , "if (-not (Test-Path $path))"
            , "{"
            , $"New-Item -Path \"{repoBuildPath}\" -Name \"{appFolder}\" -ItemType \"directory\""
            , "}"
            , "else"
            , "{"
            , $"Remove-Item \"{appProjBuildPath}\\*\" -Recurse"
            , "}"
            , $"Copy-Item -Path \"{appProjPath}\\bin\\Release\\net6.0\\publish\\*\" "
                + $"-Destination \"{appProjBuildPath}\" -Recurse"
        };
    }
}