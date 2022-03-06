using CommandDotNet;
using CommandDotNet.Unity.Helper;
using DIHelper;
using DIHelper.Unity;
using Microsoft.Extensions.Configuration;
using Unity;

namespace Scripter;

public class AppProgSet
    : UnityDependencySet
{
    public AppProgSet(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void Register()
    {
        Container.RegisterSingleton<IAppProgram, AppProg>();
        var appProg = (AppProgUnity<AppProg>)Container.Resolve<IAppProgram>();
        appProg.SetDIContainer(Container);
        appProg.Configuration = Container.Resolve<IConfiguration>();
    }
}