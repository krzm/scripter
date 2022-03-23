using CommandDotNet.Unity.Helper;
using Config.Wrapper;
using Serilog.Wrapper;
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
        RegisterSet<AppLoggerSet>();
        RegisterSet<AppConfigSet>();
        RegisterSet<AppDataSet>();
        RegisterSet<JoinableScriptSet>();
        RegisterSet<ProjBuildAllSet>();
        RegisterSet<LogBuildAllSet>();
        RegisterSet<InventoryBuildAllSet>();
        RegisterSet<BuildAllSet>();
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