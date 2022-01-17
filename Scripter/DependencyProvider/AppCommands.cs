using System.Windows.Input;
using Core.Lib;
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
        Container.RegisterSingleton<ICommand, ScriptCommand>();
    }
}