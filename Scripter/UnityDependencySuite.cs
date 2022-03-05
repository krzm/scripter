using DIHelper;
using Unity;

namespace Scripter;

public class UnityDependencySuite
    : DIHelper.Unity.UnityDependencySuite
{
    public UnityDependencySuite(
        IUnityContainer container)
        : base(container)
    {
    }

    protected override void RegisterAppData()
    {
        RegisterSet<AppDataSet>();
    }

    protected override void RegisterCommands()
    {
        RegisterSet<AppCommands>();
    }

    protected override void RegisterProgram() =>
        Container.RegisterSingleton<IAppProgram, AppProg>();
}