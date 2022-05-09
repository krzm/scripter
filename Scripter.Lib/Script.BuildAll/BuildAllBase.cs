using Scripter.Data.Helper;

namespace Scripter;

public abstract class BuildAllBase 
    : IBuildAll
{
    protected List<string> Script;
    protected readonly BuildAllDTO? BuildAllDTO;

    public string File
    {
        get
        {
            ArgumentNullException.ThrowIfNull(BuildAllDTO);
            return BuildAllDTO.File;
        }
    }

    public BuildAllBase(
        BuildAllDTO buildAllDTO)
    {
        BuildAllDTO = buildAllDTO;
        ArgumentNullException.ThrowIfNull(BuildAllDTO);
        Script = new List<string>();
    }

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