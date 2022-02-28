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
        Container.RegisterSingleton<IBuildAll, BuildAllScript>(nameof(BuildAllScript));
        Container.RegisterSingleton<ICommand, ScriptCommand>();
    }

    private void SetData()
    {
        Container.RegisterSingleton<ICodeData, LibData>(nameof(LibData));
        Container.RegisterSingleton<ICodeData, AppData>(nameof(AppData));
        Container.RegisterSingleton<ICodeData, LogData>(nameof(LogData));
        Container.RegisterSingleton<ICodeData, InventoryData>(nameof(InventoryData));
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
        Container.RegisterSingleton<IProjBuildAll, ScripterBuildAll>(nameof(ScripterBuildAll)
                    , new InjectionConstructor(Container.Resolve<ICodeData>(nameof(AppData))));
        Container.RegisterSingleton<IProjBuildAll, AppStarterBuildAll>(nameof(AppStarterBuildAll)
            , new InjectionConstructor(Container.Resolve<ICodeData>(nameof(AppData))));
        Container.RegisterSingleton<IProjBuildAll, DiyBoxBuildAll>(nameof(DiyBoxBuildAll)
            , new InjectionConstructor(Container.Resolve<ICodeData>(nameof(AppData))));
        Container.RegisterSingleton<IProjBuildAll, GameDataBuildAll>(nameof(GameDataBuildAll)
            , new InjectionConstructor(Container.Resolve<ICodeData>(nameof(AppData))));
    }

    private void SetLogBuildAll()
    {
        Container.RegisterSingleton<IProjBuildAll, ConsoleLogBuildAll>(nameof(ConsoleLogBuildAll)
            , new InjectionConstructor(Container.Resolve<ICodeData>(nameof(LogData))));
        Container.RegisterSingleton<IProjBuildAll, ModernMDILogBuildAll>(nameof(ModernMDILogBuildAll)
            , new InjectionConstructor(Container.Resolve<ICodeData>(nameof(LogData))));
        Container.RegisterSingleton<IProjBuildAll, ModernLogWizardBuildAll>(nameof(ModernLogWizardBuildAll)
            , new InjectionConstructor(Container.Resolve<ICodeData>(nameof(LogData))));
        Container.RegisterSingleton<IProjBuildAll, ModernLogBuildAll>(nameof(ModernLogBuildAll)
            , new InjectionConstructor(Container.Resolve<ICodeData>(nameof(LogData))));
    }

    private void SetInventoryBuildAll()
    {
        Container.RegisterSingleton<IProjBuildAll, ConsoleInventoryBuildAll>(nameof(ConsoleInventoryBuildAll)
            , new InjectionConstructor(Container.Resolve<ICodeData>(nameof(InventoryData))));
        Container.RegisterSingleton<IProjBuildAll, ModernInventoryBuildAll>(nameof(ModernInventoryBuildAll)
            , new InjectionConstructor(Container.Resolve<ICodeData>(nameof(InventoryData))));
    }   
}