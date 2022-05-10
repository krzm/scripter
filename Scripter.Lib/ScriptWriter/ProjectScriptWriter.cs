using Scripter.Data.Helper;

namespace Scripter.Lib;

public class ProjectScriptWriter
    : ScriptWriter
{
    private readonly IProjectList? projList;
    private readonly IScriptParam? scriptParam;
    private readonly List<IScript>? projScripts;

    public ProjectScriptWriter(
        IProjectList projList
        , IScriptParam scriptParam
        , List<IScript> projectScripts
        )
    {
        this.projList = projList;
        this.scriptParam = scriptParam;
        this.projScripts = projectScripts;

        ArgumentNullException.ThrowIfNull(this.projList);
    }

    public override void WriteScripts()
    {
        var projects = projList?.Projects;
        ArgumentNullException.ThrowIfNull(projects);
        foreach (var project in projects)
        {
            SetProject(project);
            ArgumentNullException.ThrowIfNull(scriptParam);
            ArgumentNullException.ThrowIfNull(scriptParam.Project);
            ArgumentNullException.ThrowIfNull(projScripts);
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
        ArgumentNullException.ThrowIfNull(scriptParam);
        scriptParam.Project = new ProjectDTO(
            project.RepoFolder
            , project.ProjFolder
            , IsApp: project.IsApp);
    }

    private void WriteScript(IScript script)
    {
        ArgumentNullException.ThrowIfNull(scriptParam);
        ArgumentNullException.ThrowIfNull(scriptParam.Project);
        File.WriteAllLines(
            Path.Combine(scriptParam.ScriptPath
                , script.File)
            , script.GetScript());
    }
}