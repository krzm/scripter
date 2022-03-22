using System.Windows.Input;

namespace Scripter.Lib;

public class ScriptCommand : ICommand
{
    public event EventHandler? CanExecuteChanged;
    private readonly IProjectList projectList;
    private readonly List<ICodeData> codeData;
    private readonly IScriptParam scriptParam;
    private readonly List<IScript> projectScripts;
    private readonly List<IProjBuildAll> projBuildAllScripts;
    private readonly IBuildAll buildAllScript;

    public ScriptCommand(
        IProjectList projectList
        , List<ICodeData> codeData
        , IScriptParam scriptParam
        , List<IScript> projectScripts
        , List<IProjBuildAll> projBuildAllScripts
        , IBuildAll buildAllScript)
    {
        this.projectList = projectList;
        this.codeData = codeData;
        this.scriptParam = scriptParam;
        this.projectScripts = projectScripts;
        this.projBuildAllScripts = projBuildAllScripts;
        this.buildAllScript = buildAllScript;
    }

    public bool CanExecute(object? parameter) => true;

    public void Execute(object? parameter)
    {
        WriteProjectScripts();
        WriteProjBuildAllScripts();
        WriteScript(buildAllScript);
    }

    private void WriteProjectScripts()
    {
        foreach (var project in projectList.Projects)
        {
            SetProject(project);
            ArgumentNullException.ThrowIfNull(scriptParam.Project);
            foreach (var script in projectScripts)
            {
                if (scriptParam.Project.IsApp == false
                    && script is CopyAppScript) continue;
                WriteScript(script);
            }
        }
    }

    private void SetProject(ProjectDTO project)
    {
        scriptParam.Project = new ProjectDTO(
            project.RepoFolder
            , project.ProjFolder
            , IsApp: project.IsApp);
    }

    private void WriteScript(IScript script)
    {
        ArgumentNullException.ThrowIfNull(scriptParam.Project);
        File.WriteAllLines(
            Path.Combine(scriptParam.ScriptPath
                , script.File)
            , script.GetScript());
    }

    private void WriteProjBuildAllScripts()
    {
        foreach (var script in projBuildAllScripts)
        {
            WriteScript(script);   
        }
    }

    private void WriteScript(IProjBuildAll buildScript)
    {
        ArgumentNullException.ThrowIfNull(scriptParam.Project);
        File.WriteAllLines(
            Path.Combine(scriptParam.ScriptPath
                , buildScript.File)
                , buildScript.GetScript());
    }

    private void WriteScript(IBuildAll buildScript)
    {
        ArgumentNullException.ThrowIfNull(scriptParam.Project);
        File.WriteAllLines(
            Path.Combine(scriptParam.ScriptPath
                , buildScript.File)
            , buildScript.GetScript());
    }
}