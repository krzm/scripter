using System.Windows.Input;

namespace Scripter.Lib;

public class ScriptCommand : ICommand
{
    public event EventHandler? CanExecuteChanged;

    private readonly IList<ProjectDTO> projects;
    private readonly IScriptParam scriptParam;
    private readonly List<IScript> projectScripts;
    private readonly List<IBuildAll> buildAllScripts;

    public ScriptCommand(
        IList<ProjectDTO> projects
        , IScriptParam scriptParam
        , List<IScript> projectScripts
        , List<IBuildAll> buildAllScripts)
    {
        this.projects = projects;
        this.scriptParam = scriptParam;
        this.projectScripts = projectScripts;
        this.buildAllScripts = buildAllScripts;
    }

    public bool CanExecute(object? parameter) => true;

    public void Execute(object? parameter)
    {
        WriteProjectScripts();
        WriteBuildAllScripts();
    }

    private void WriteProjectScripts()
    {
        foreach (var project in projects)
        {
            scriptParam.Project = new ProjectDTO(project.RepoFolder, project.AppProjFolder);
            foreach (var script in projectScripts)
            {
                File.WriteAllLines(
                    Path.Combine(scriptParam.ScriptPath, script.File)
                    , script.GetScript());
            }
        }
    }
    
    private void WriteBuildAllScripts()
    {
        foreach (var script in buildAllScripts)
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