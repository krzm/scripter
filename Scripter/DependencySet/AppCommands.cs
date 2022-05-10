using System.Windows.Input;
using DIHelper.Unity;
using Scripter.Data.Helper;
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
        Container.RegisterSingleton<ICommand, ScriptCommand>();
    }
}