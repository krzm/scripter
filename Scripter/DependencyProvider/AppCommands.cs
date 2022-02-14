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
        Container.RegisterSingleton<ICodeData, LogData>();

        Container.RegisterSingleton<IScriptParam, ScriptParam>();
        
        Container.RegisterSingleton<IScript, CompileScript>(nameof(CompileScript));
        Container.RegisterSingleton<IScript, VersionScript>(nameof(VersionScript));
        Container.RegisterSingleton<IScript, CopyScript>(nameof(CopyScript));
        Container.RegisterSingleton<IScript, BuildScript>(nameof(BuildScript));

        Container.RegisterSingleton<IBuildAll, BuildAllScript>(nameof(BuildAllScript));
        Container.RegisterSingleton<IBuildAll, ScripterBuildAll>(nameof(ScripterBuildAll));

        Container.RegisterSingleton<IBuildAll, ConsoleLogBuildAll>(nameof(ConsoleLogBuildAll));
        Container.RegisterSingleton<IBuildAll, ModernMDILogBuildAll>(nameof(ModernMDILogBuildAll));
        Container.RegisterSingleton<IBuildAll, ModernLogWizardBuildAll>(nameof(ModernLogWizardBuildAll));
        Container.RegisterSingleton<IBuildAll, ModernLogBuildAll>(nameof(ModernLogBuildAll));
        
        Container.RegisterSingleton<IBuildAll, ModernInventoryBuildAll>(nameof(ModernInventoryBuildAll));
        Container.RegisterSingleton<IBuildAll, AppStarterBuildAll>(nameof(AppStarterBuildAll));
        Container.RegisterSingleton<IBuildAll, DiyBoxBuildAll>(nameof(DiyBoxBuildAll));

        Container.RegisterSingleton<ICommand, ScriptCommand>();
    }
}