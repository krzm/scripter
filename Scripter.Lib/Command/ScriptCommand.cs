using System.Windows.Input;

namespace Scripter.Lib;

public class ScriptCommand : ICommand
{
    public event EventHandler? CanExecuteChanged;

    private readonly IList<ProjectDTO> projects;
    private readonly IScriptParam scriptParam;
    private readonly List<IScript> scripts;
    private readonly IBuildAllScript buildAllScript;

    public ScriptCommand(
        IList<ProjectDTO> projects
        , IScriptParam scriptParam
        , List<IScript> scripts
        , IBuildAllScript buildAllScript)
    {
        this.projects = projects;
        this.scriptParam = scriptParam;
        this.scripts = scripts;
        this.buildAllScript = buildAllScript;
    }

    public bool CanExecute(object? parameter) => true;

    public void Execute(object? parameter)
    {
        WriteProjectScripts();
        WriteBuildAllScript();
    }

    private void WriteProjectScripts()
    {
        foreach (var project in projects)
        {
            scriptParam.Project = new ProjectDTO(project.RepoFolder, project.AppProjFolder);
            foreach (var script in scripts)
            {
                File.WriteAllLines(
                    Path.Combine(scriptParam.ScriptPath, script.File)
                    , script.GetScript());
            }
        }
    }
    
    private void WriteBuildAllScript()
    {
        File.WriteAllLines(
            Path.Combine(scriptParam.ScriptPath, buildAllScript.File)
            , buildAllScript.GetScript());
    }
}