using System.Windows.Input;
using DIHelper.Unity;
using Scripter.Lib;
using Unity;
using Unity.Injection;

namespace Scripter;

public class AppCommands 
    : UnityDependencySet
{
    public AppCommands(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void Register()
    {
        SetData();
        SetJoinable();
        SetProjectBuildAll();
        SetLogBuildAll();
        SetInventoryBuildAll();
        Container.RegisterSingleton<IBuildAll, BuildAllScript>();
        Container.RegisterSingleton<ICommand, ScriptCommand>();
    }

    private void SetData()
    {
        Container.RegisterSingleton<ICodeData, LibData>(nameof(LibData));
        Container.RegisterSingleton<ICodeData, AppData>(nameof(AppData));
        Container.RegisterSingleton<ICodeData, LogData>(nameof(LogData));
        Container.RegisterSingleton<ICodeData, InventoryData>(nameof(InventoryData));

        Container.RegisterType<IProjectExtractor, ProjectExtractor>();
        
        Container.RegisterSingleton<IProjectList, ProjectList>();
    }

    private void SetJoinable()
    {
        Container.RegisterSingleton<IScriptParam, ScriptParam>();

        Container.RegisterSingleton<IScript, CompileScript>(nameof(CompileScript));
        Container.RegisterSingleton<IScript, VersionScript>(nameof(VersionScript));
        Container.RegisterSingleton<IScript, CopyScript>(nameof(CopyScript));
        Container.RegisterSingleton<IScript, CopyAppScript>(nameof(CopyAppScript));
        Container.RegisterSingleton<IScript, BuildScript>(nameof(BuildScript));
    }

    private void SetProjectBuildAll()
    {
        RegisterProjBuildAll<ScripterBuildAll, AppData>();
        RegisterProjBuildAll<AppStarterBuildAll, AppData>();
        RegisterProjBuildAll<DiyBoxBuildAll, AppData>();
        RegisterProjBuildAll<GameDataBuildAll, AppData>();
    }

    private void RegisterProjBuildAll<TScript, TData>()
        where TScript : IProjBuildAll
        where TData : ICodeData
    {
        Container.RegisterSingleton<IProjBuildAll, TScript>(
                    typeof(TScript).Name
                    , new InjectionConstructor(
                        Container.Resolve<IProjectExtractor>()
                        , Container.Resolve<ICodeData>(typeof(TData).Name)));
    }

    private void SetLogBuildAll()
    {
        RegisterProjBuildAll<ConsoleLogBuildAll, LogData>();
        RegisterProjBuildAll<ModernMDILogBuildAll, LogData>();
        RegisterProjBuildAll<ModernLogWizardBuildAll, LogData>();
        RegisterProjBuildAll<ModernLogBuildAll, LogData>();
    }

    private void SetInventoryBuildAll()
    {
        RegisterProjBuildAll<ConsoleInventoryBuildAll, InventoryData>();
        RegisterProjBuildAll<ModernInventoryBuildAll, InventoryData>();
    }   
}