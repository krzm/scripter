using System.Windows.Input;
using DIHelper.Unity;
using Scripter.Lib;
using Unity;

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
        Container.RegisterSingleton<IList<ProjectDTO>, ProjectList>();
        Container.RegisterSingleton<ICodeData, AppData>();

        Container.RegisterSingleton<IScriptParam, ScriptParam>();
        
        Container.RegisterSingleton<IScript, CompileScript>(nameof(CompileScript));
        Container.RegisterSingleton<IScript, VersionScript>(nameof(VersionScript));
        Container.RegisterSingleton<IScript, CopyScript>(nameof(CopyScript));
        Container.RegisterSingleton<IScript, BuildScript>(nameof(BuildScript));

        Container.RegisterSingleton<IBuildAll, BuildAllScript>(nameof(BuildAllScript));
        Container.RegisterSingleton<IBuildAll, ScripterBuildAll>(nameof(ScripterBuildAll));
        Container.RegisterSingleton<IBuildAll, ModernLogBuildAll>(nameof(ModernLogBuildAll));
        Container.RegisterSingleton<IBuildAll, ModernInventoryBuildAll>(nameof(ModernInventoryBuildAll));
        Container.RegisterSingleton<IBuildAll, AppStarterBuildAll>(nameof(AppStarterBuildAll));

        Container.RegisterSingleton<ICommand, ScriptCommand>();
    }
}