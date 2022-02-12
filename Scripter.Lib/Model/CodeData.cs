namespace Scripter;

public abstract class CodeData 
    : CodeProject
        , ICodeData
{
    public CodeData()
    {
        SetAll();
    }

    private void SetAll()
    {
        SetIndependentLib();
        SetOneDependancyLib();
        SetTwoDependancyLib();
        SetManyDependancyLib();
        SetApps();
    }

    protected abstract void SetIndependentLib();
    protected abstract void SetOneDependancyLib();
    protected abstract void SetTwoDependancyLib();
    protected abstract void SetManyDependancyLib();
    protected virtual void SetApps(){}

    protected ProjectDTO Set(string repo, string project)
    {
        var proj = new ProjectDTO(repo, project);
        Add(proj.AppProjFolder, proj);
        return proj;
    }

    protected ProjectDTO Set(string repo, string project
        , params ProjectDTO[] libs)
    {
        var proj = new ProjectDTO(repo, project
            , new List<ProjectDTO>(libs));
        Add(proj.AppProjFolder, proj);
        return proj;
    }
}