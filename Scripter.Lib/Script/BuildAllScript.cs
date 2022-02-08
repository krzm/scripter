namespace Scripter;

public class BuildAllScript : IBuildAllScript
{
    private readonly IList<ProjectDTO> projectList;

    public string File => "BuildAll.ps1";

    public BuildAllScript(IList<ProjectDTO> projectList)
    {
        this.projectList = projectList;
    }

    public string[] GetScript()
    {
        var sb = new List<string>();
        foreach (var project in projectList)
        {
            sb.Add($"& \"$PSScriptRoot\\{project.AppProjFolder}.Build.ps1\"");
        }
        return sb.ToArray();
    }
}