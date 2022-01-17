using CLI.Core;
using Unity;

namespace Scripter;

public class UnityDependencyCollection : CLI.Core.Lib.UnityDependencyCollection
{
    public UnityDependencyCollection(
        IUnityContainer container)
        : base(container)
    {
    }

    protected override void RegisterCommands()
    {
        RegisterDependencyProvider<AppCommands>();
    }

    protected override void RegisterProgram() =>
        Container.RegisterSingleton<IAppProgram, AppProgram>();
}