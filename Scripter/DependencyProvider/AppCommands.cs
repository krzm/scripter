using System.Windows.Input;
using Core.Lib;
using Scripter.Lib;
using Unity;

namespace Scripter;

public class AppCommands : UnityDependencyProvider
{
    public AppCommands(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void RegisterDependencies()
    {
        Container.RegisterSingleton<IScriptVariables, ScriptVariables>();
        Container.RegisterSingleton<IScript, VersionScript>(nameof(VersionScript));
        Container.RegisterSingleton<IScript, CompileScript>(nameof(CompileScript));

        Container.RegisterSingleton<ICommand, ScriptCommand>();
    }
}