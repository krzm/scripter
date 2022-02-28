namespace Scripter;

public abstract class BuildAllBase 
    : IBuildAll
{
    protected List<string> Script;

    public abstract string File { get; }

    public abstract string[] GetScript();

    private bool IsNotInScript(ProjectDTO project)
    {
        foreach (var line in Script)
        {
            if(line.Contains(project.ProjFolder)) return false;
        }
        return true;
    }

    protected void AddLine(ProjectDTO project)
    {
        if(IsNotInScript(project))
            Script.Add($"& \"$PSScriptRoot\\{project.ProjFolder}.Build.ps1\"");
    }
}