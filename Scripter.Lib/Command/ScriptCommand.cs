using System.Windows.Input;

namespace Scripter.Lib;

public class ScriptCommand : ICommand
{
    public event EventHandler? CanExecuteChanged;

    private readonly IList<ProjectDTO> projects;
    private readonly IScriptParam scriptParam;
    private readonly List<IScript> scripts;
    private readonly List<IBuildScript> buildScripts;

    public ScriptCommand(
        IList<ProjectDTO> projects
        , IScriptParam scriptParam
        , List<IScript> scripts
        , List<IBuildScript> buildScripts)
    {
        this.projects = projects;
        this.scriptParam = scriptParam;
        this.scripts = scripts;
        this.buildScripts = buildScripts;
    }

    public bool CanExecute(object? parameter) => true;

    public void Execute(object? parameter)
    {
        WriteProjectScripts();
        WriteBuildAllScript(buildScripts[0]);
        WriteBuildModernLogScript(buildScripts[1]);
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
    
    private void WriteBuildAllScript(IBuildScript buildScript)
    {
        if (buildScript is not BuildAllScript)
            throw new ArgumentException("Wrong script");
        WriteScript(buildScript);
    }

    private void WriteScript(IBuildScript buildScript)
    {
        File.WriteAllLines(
            Path.Combine(scriptParam.ScriptPath, buildScript.File)
            , buildScript.GetScript());
    }

    private void WriteBuildModernLogScript(IBuildScript buildScript)
    {
        if(buildScript is not BuildModernLogScript)
            throw new ArgumentException("Wrong script");
        WriteScript(buildScript);
    }
}