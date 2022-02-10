namespace Scripter;

public abstract class CodeDataBase 
    : Dictionary<string,ProjectDTO>
        , ICodeData
{
    protected ProjectDTO? ModelHelper;
    protected ProjectDTO? EFCoreHelper;
    protected ProjectDTO? DotNetExtension;
    protected ProjectDTO? CommandDotNetUnity;
    protected ProjectDTO? CliHelper;
    protected ProjectDTO? DataToTable;
    protected ProjectDTO? CliReader;
    protected ProjectDTO? LogData;
    protected ProjectDTO? DiHelper;
    protected ProjectDTO? CommandDotNetHelper;
    protected ProjectDTO? CrudCommandHelper;
    protected ProjectDTO? LogModernLib;
    protected ProjectDTO? LogModernConsoleApp;

    public CodeDataBase()
    {
        SetAll();
    }

    private void SetAll()
    {
        SetIndependent();
        SetOneDependancy();
        SetTwoDependancy();
        SetManyDependancy();
    }

    protected abstract void SetIndependent();
    protected abstract void SetOneDependancy();
    protected abstract void SetTwoDependancy();
    protected abstract void SetManyDependancy();

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