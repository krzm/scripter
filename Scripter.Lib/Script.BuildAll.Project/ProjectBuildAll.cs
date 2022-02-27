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
        var project = appData[Project];
        if (project == null) 
            throw new ArgumentException($"{project} not found");
        AddScript(project);
        return script.ToArray();
    }

    private void AddScript(ProjectDTO project)
    {
        if (project.Dependencies != null)
        {
            foreach (var library in project.Dependencies)
            {
                if (library == null) 
                    throw new NullReferenceException($"{library} is null");
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
            if(line.Contains(project.ProjFolder)) return false;
        }
        return true;
    }

    private void AddLine(ProjectDTO project)
    {
        script.Add($"& \"$PSScriptRoot\\{project.ProjFolder}.Build.ps1\"");
    }
}
