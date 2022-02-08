namespace Scripter;

public class BuildModernLogScript : IBuildScript
{
    private readonly IModernLogBuild modernLogBuild;

    public string File => "BuildModernLog.ps1";

    public BuildModernLogScript(IModernLogBuild modernLogBuild)
    {
        this.modernLogBuild = modernLogBuild;
    }

    public string[] GetScript()
    {
        var sb = new List<string>();
        foreach (var project in modernLogBuild.Libs)
        {
            sb.Add($"& \"$PSScriptRoot\\{project.AppProjFolder}.Build.ps1\"");
        }
        sb.Add($"& \"$PSScriptRoot\\{modernLogBuild.App}.Build.ps1\"");
        return sb.ToArray();
    }
}