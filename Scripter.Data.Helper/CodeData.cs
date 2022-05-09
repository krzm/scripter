namespace Scripter.Data.Helper;

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
        , string project
        , DateOnly lastCheck)
    {
        var proj = new ProjectDTO(
            repo
            , project
            , default
            , false
            , lastCheck);
        Add(proj.ProjFolder, proj);
        return proj;
    }

    protected ProjectDTO Set(
        string repo
        , string project
        , DateOnly lastCheck
        , params ProjectDTO[] libs)
    {
        var proj = new ProjectDTO(
            repo
            , project
            , new List<ProjectDTO>(libs)
            , false
            , lastCheck);
        Add(proj.ProjFolder, proj);
        return proj;
    }

    protected ProjectDTO Set(
        string repo
        , string project
        , bool isApp = false
        , DateOnly lastCheck = default
        , params ProjectDTO[] libs)
    {
        var proj = new ProjectDTO(
            repo
            , project
            , new List<ProjectDTO>(libs)
            , isApp
            , lastCheck);
        Add(proj.ProjFolder, proj);
        return proj;
    }
}