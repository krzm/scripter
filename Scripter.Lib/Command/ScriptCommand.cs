using System.Windows.Input;

namespace Scripter.Lib;

public class ScriptCommand : ICommand
{
    public event EventHandler? CanExecuteChanged;

    private readonly List<ICodeData> codeData;
    private readonly IScriptParam scriptParam;
    private readonly List<IScript> projectScripts;
    private readonly List<IProjBuildAll> projBuildAllScripts;
    private List<ProjectDTO> projects;

    public ScriptCommand(
        List<ICodeData> codeData
        , IScriptParam scriptParam
        , List<IScript> projectScripts
        , List<IProjBuildAll> projBuildAllScripts)
    {
        this.codeData = codeData;
        this.scriptParam = scriptParam;
        this.projectScripts = projectScripts;
        this.projBuildAllScripts = projBuildAllScripts;
        projects = new List<ProjectDTO>();
    }

    public bool CanExecute(object? parameter) => true;

    public void Execute(object? parameter)
    {
        WriteProjectScripts();
        WriteBuildAllScripts();
    }

    private void WriteProjectScripts()
    {
        projects.Clear();
        foreach (var data in codeData)
        {
            foreach (var proj in data.Values)
            {
                SelectProjects(proj);
            }
        }

        foreach (var project in projects)
        {
            scriptParam.Project = new ProjectDTO(
                project.RepoFolder
                , project.ProjFolder
                , IsApp: project.IsApp);
            foreach (var script in projectScripts)
            {
                if(scriptParam.Project.IsApp == false
                    && script is CopyAppScript) continue;
                File.WriteAllLines(
                    Path.Combine(scriptParam.ScriptPath, script.File)
                    , script.GetScript());
            }
        }
    }
    
    private void SelectProjects(ProjectDTO project)
    {
        if (project.Dependencies != null)
        {
            foreach (var library in project.Dependencies)
            {
                if (library == null) 
                    throw new NullReferenceException($"{library} is null");
                SelectProjects(library);
            }
        }
        if(IsNotInScript(project))
            projects.Add(project);
    }

    private bool IsNotInScript(ProjectDTO project)
    {
        return projects.Contains(project) == false;
    }

    private void WriteBuildAllScripts()
    {
        foreach (var script in projBuildAllScripts)
        {
            WriteScript(script);   
        }
    }

    private void WriteScript(IBuildAll buildScript)
    {
        File.WriteAllLines(
            Path.Combine(scriptParam.ScriptPath, buildScript.File)
            , buildScript.GetScript());
    }
}