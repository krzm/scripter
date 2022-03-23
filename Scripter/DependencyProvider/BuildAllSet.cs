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
            "BuildAll"
            , new InjectionConstructor(
                Container.Resolve<IProjectList>(
                    nameof(AllProjList))
                , new BuildAllDTO("BuildAll.ps1")));
        
        Container.RegisterSingleton<IBuildAll, BuildAllScript>(
            "LibBuildAll"
            , new InjectionConstructor(
                Container.Resolve<IProjectList>(
                    nameof(ProjList))
                , new BuildAllDTO("LibBuildAll.ps1")));
    }
}