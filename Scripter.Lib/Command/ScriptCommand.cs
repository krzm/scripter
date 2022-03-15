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
        WriteBuildAllScripts();
        WriteScript(buildAllScript);
    }

    private void WriteProjectScripts()
    {
        ArgumentNullException.ThrowIfNull(scriptParam.Project);
        foreach (var project in projectList.Projects)
        {
            SetProject(project);
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
        File.WriteAllLines(
            Path.Combine(scriptParam.ScriptPath, script.File)
            , script.GetScript());
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