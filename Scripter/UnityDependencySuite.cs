﻿using CommandDotNet.Unity.Helper;
using Config.Wrapper.Unity;
using Serilog.Wrapper.Unity;
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
        RegisterSet<CodeDataSet>();
        RegisterSet<JoinableScriptSet>();
        RegisterSet<ProjectListSetA>();
        RegisterSet<ProjectListSetB>();
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