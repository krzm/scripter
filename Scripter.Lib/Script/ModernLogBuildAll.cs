namespace Scripter;

public class ModernLogBuildAll : IBuildAll
{
    private readonly IModernLogData projectData;
    private List<string> script;

    public string File => "ModernLog.Build.ps1";

    public ModernLogBuildAll(IModernLogData projectData)
    {
        this.projectData = projectData;
    }

    public string[] GetScript()
    {
        script = new List<string>();
        foreach (var project in projectData)
        {
            AddScript(project);
        }
        return script.ToArray();
    }

    private void AddScript(ProjectDTO project)
    {
        if (project.Dependencies != null)
        {
            foreach (var library in project.Dependencies)
            {
                AddScript(library);
            }
        }
        if(IsNotInScript(project))
            AddLine(project);
    }

    private bool IsNotInScript(ProjectDTO project)
    {
        foreach (var line in script)
        {
            if(line.Contains(project.AppProjFolder)) return false;
        }
        return true;
    }

    private void AddLine(ProjectDTO project)
    {
        script.Add($"& \"$PSScriptRoot\\{project.AppProjFolder}.Build.ps1\"");
    }
}