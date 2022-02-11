namespace Scripter;

public abstract class CodeData 
    : Dictionary<string,ProjectDTO>
        , ICodeData
{
    protected ProjectDTO? ModelHelper;
    protected ProjectDTO? EFCoreHelper;
    protected ProjectDTO? DotNetExtension;
    protected ProjectDTO? DotNetTool;
    protected ProjectDTO? CLIHelper;
    protected ProjectDTO? DataToTable;
    protected ProjectDTO? CLIReader;
    protected ProjectDTO? CommandDotNetUnity;
    protected ProjectDTO? DIHelper;
    protected ProjectDTO? CommandDotNetHelper;
    protected ProjectDTO? CRUDCommandHelper;
    protected ProjectDTO? CLIFramework;
    protected ProjectDTO? CLIWizardHelper;
    protected ProjectDTO? Scripter;
    protected ProjectDTO? LogData;
    protected ProjectDTO? LogModernLib;
    protected ProjectDTO? LogModernConsoleApp;
    protected ProjectDTO? InventoryData;
    protected ProjectDTO? InventoryModernLib;
    protected ProjectDTO? InventoryModernConsoleApp;
    protected ProjectDTO? AppStarterData;
    protected ProjectDTO? AppStarterModernLib;
    protected ProjectDTO? AppStarterConsoleApp;

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