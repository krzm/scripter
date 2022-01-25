using System.Windows.Input;

namespace Scripter.Lib;

public class ScriptCommand : ICommand
{
    public event EventHandler? CanExecuteChanged;

    private readonly IList<ProjectDTO> projects;
    private readonly IScriptParam scriptParam;
    private readonly List<IScript> scripts;

    public ScriptCommand(
        IList<ProjectDTO> projects
        , IScriptParam scriptParam
        , List<IScript> scripts)
    {
        this.projects = projects;
        this.scriptParam = scriptParam;
        this.scripts = scripts;
    }

    public bool CanExecute(object? parameter) => true;

    public void Execute(object? parameter)
    {
        foreach (var project in projects)
        {
            scriptParam.Project = new ProjectDTO(project.RepoFolder, project.AppProjFolder);
            foreach (var script in scripts)
            {
                var filePath = Path.Combine(scriptParam.ScriptPath, script.File);
                File.WriteAllLines(filePath, script.GetScript());
            }
        }
    }
}