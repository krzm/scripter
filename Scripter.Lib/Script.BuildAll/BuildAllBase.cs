namespace Scripter;

public abstract class BuildAllBase 
    : IBuildAll
{
    protected List<string> Script;

    public abstract string File { get; }

    public abstract string[] GetScript();

    protected void SelectScript(ProjectDTO project)
    {
        if (project.Dependencies != null)
        {
            foreach (var library in project.Dependencies)
            {
                if (library == null) 
                    throw new NullReferenceException($"{library} is null");
                SelectScript(library);
            }
        }
        if(IsNotInScript(project))
            AddLine(project);
    }

    private bool IsNotInScript(ProjectDTO project)
    {
        foreach (var line in Script)
        {
            if(line.Contains(project.ProjFolder)) return false;
        }
        return true;
    }

    private void AddLine(ProjectDTO project)
    {
        Script.Add($"& \"$PSScriptRoot\\{project.ProjFolder}.Build.ps1\"");
    }
}
