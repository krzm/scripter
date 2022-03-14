using CommandDotNet.Unity.Helper;
using Config.Wrapper;
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
        RegisterSet<AppConfigSet>();
        RegisterSet<AppDataSet>();
    }

    protected override void RegisterCommands()
    {
        RegisterSet<AppCommands>();
    }

    protected override void RegisterProgram()
    {
        RegisterSet<AppProgSet<AppProg>>();
    }
}