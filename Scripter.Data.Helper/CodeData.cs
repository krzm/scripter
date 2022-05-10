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
            RepoFolder: repo
            , ProjFolder: project
            , Dependencies: new List<ProjectDTO>()
            , IsApp: false
            , IsWpf: false
            , LastCheck: lastCheck);
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
            RepoFolder: repo
            , ProjFolder: project
            , Dependencies: new List<ProjectDTO>(libs)
            , IsApp: false
            , IsWpf: false
            , LastCheck: lastCheck);
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
            RepoFolder: repo
            , ProjFolder: project
            , Dependencies: new List<ProjectDTO>(libs)
            , IsApp: isApp
            , IsWpf: false
            , LastCheck: lastCheck);
        Add(proj.ProjFolder, proj);
        return proj;
    }

    protected ProjectDTO Set(
        string repo
        , string project
        , bool isApp = false
        , bool isWpf = false
        , DateOnly lastCheck = default
        , params ProjectDTO[] libs)
    {
        var proj = new ProjectDTO(
            RepoFolder: repo
            , ProjFolder: project
            , Dependencies: new List<ProjectDTO>(libs)
            , IsApp: isApp
            , IsWpf: isWpf
            , LastCheck: lastCheck);
        Add(proj.ProjFolder, proj);
        return proj;
    }
}