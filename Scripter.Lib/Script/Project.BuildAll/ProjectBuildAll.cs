namespace Scripter;

public abstract class ProjectBuildAll : IBuildAll
{
    private readonly ICodeData appData;
    private List<string> script;

    public abstract string File { get; }

    public abstract string Project { get; }

    public ProjectBuildAll(ICodeData appData)
    {
        this.appData = appData;
    }

    public string[] GetScript()
    {
        script = new List<string>();
        AddScript(appData[Project]);
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
