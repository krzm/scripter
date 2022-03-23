using DIHelper.Unity;
using Unity;
using Unity.Injection;

namespace Scripter;

public class BuildAllSet 
    : UnityDependencySet
{
    public BuildAllSet(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void Register()
    {
        Container.RegisterSingleton<IBuildAll, BuildAllScript>(
            new InjectionConstructor(
                Container.Resolve<IProjectList>()
                , new BuildAllDTO("BuildAll.ps1")));
    }
}