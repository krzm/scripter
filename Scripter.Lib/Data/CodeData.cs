namespace Scripter;

public abstract class CodeData 
    : Dictionary<string,ProjectDTO>
        , ICodeData
{
    public CodeData()
    {
        SetAllData();
    }

    protected abstract void SetAllData();
    
    protected ProjectDTO Set(
        string repo
        , string project)
    {
        var proj = new ProjectDTO(repo, project);
        Add(proj.ProjFolder, proj);
        return proj;
    }

    protected ProjectDTO Set(
        string repo
        , string project
        , params ProjectDTO[] libs)
    {
        var proj = new ProjectDTO(
            repo
            , project
            , new List<ProjectDTO>(libs));
        Add(proj.ProjFolder, proj);
        return proj;
    }

    protected ProjectDTO Set(
        string repo
        , string project
        , bool isApp = false
        , params ProjectDTO[] libs)
    {
        var proj = new ProjectDTO(
            repo
            , project
            , new List<ProjectDTO>(libs)
            , isApp);
        Add(proj.ProjFolder, proj);
        return proj;
    }
}