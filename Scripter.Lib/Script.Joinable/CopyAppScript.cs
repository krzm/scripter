namespace Scripter;

public class CopyAppScript : IScript
{
    private const string appsPath = $@"C:\kmazanek@gmail.com\Apps";  

    private readonly IScriptParam data;

    public string File => $"{data.Project.AppProjFolder}.CopyApp.ps1";

    public CopyAppScript(IScriptParam data)
    {
        this.data = data;
    }

    public string[] GetScript()
    {
        var projBuildPath = Path.Combine(
            data.BuildPath
            , data.Project.RepoFolder
            , data.Project.AppProjFolder);
        return new string[]
        {
            $"$buildPath1 = \"{projBuildPath}\""
            , $"$appsPath1 = \"{appsPath}\""
            , $"$buildPath2 = \"{projBuildPath}\\*\""
            , $"$appsPath2 = \"{appsPath}\\{data.Project.AppProjFolder}\""
            , "$buildPath3 = \"C:\\kmazanek@gmail.com\\Build\\Version.csv\""
            , "Copy-Item -Path $buildPath1 -Destination $appsPath1 -Force"
            , "Copy-Item -Path $buildPath2 -Destination $appsPath2 -Recurse -Force"
            , "Copy-Item -Path $buildPath3 -Destination $appsPath1 -Force"
        };
    }
}