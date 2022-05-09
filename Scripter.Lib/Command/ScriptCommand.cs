using System.Windows.Input;
using Scripter.Data.Helper;

namespace Scripter.Lib;

public class ScriptCommand : ICommand
{
    public event EventHandler? CanExecuteChanged;
    private readonly IProjectList projList;
    private readonly List<ICodeData> codeData;
    private readonly IScriptParam scriptParam;
    private readonly List<IScript> projScripts;
    private readonly List<IProjBuildAll> projBuildAllScripts;
    private readonly List<IBuildAll> buildAllScripts;

    public ScriptCommand(
        IProjectList projList
        , List<ICodeData> codeData
        , IScriptParam scriptParam
        , List<IScript> projectScripts
        , List<IProjBuildAll> projBuildAllScripts
        , List<IBuildAll> buildAllScripts)
    {
        this.projList = projList;
        this.codeData = codeData;
        this.scriptParam = scriptParam;
        this.projScripts = projectScripts;
        this.projBuildAllScripts = projBuildAllScripts;
        this.buildAllScripts = buildAllScripts;

        ArgumentNullException.ThrowIfNull(this.projList);
        ArgumentNullException.ThrowIfNull(this.codeData);
        ArgumentNullException.ThrowIfNull(this.scriptParam);
        ArgumentNullException.ThrowIfNull(this.projScripts);
        ArgumentNullException.ThrowIfNull(this.projBuildAllScripts);
        ArgumentNullException.ThrowIfNull(this.buildAllScripts);
    }

    public void Invalidate()
    {
        CanExecuteChanged?.BeginInvoke(this, new EventArgs(), null, null);
    }

    public bool CanExecute(object? parameter) => true;

    public void Execute(object? parameter)
    {
        WriteProjectScripts();
        WriteProjBuildAllScripts();
        WriteBuildAllScripts();
    }

    private void WriteProjectScripts()
    {
        foreach (var project in projList.Projects)
        {
            SetProject(project);
            ArgumentNullException.ThrowIfNull(scriptParam.Project);
            foreach (var script in projScripts)
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

    private void WriteBuildAllScripts()
    {
        foreach (var script in buildAllScripts)
        {
            WriteScript(script);   
        }
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