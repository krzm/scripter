using DIHelper.Unity;
using Unity;
using Unity.Injection;

namespace Scripter;

public class ProjectListSet 
    : UnityDependencySet
{
    public ProjectListSet(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void Register()
    {
        Container
            .RegisterType<IProjectExtractor, ResetingProjExtractor>(
                nameof(ResetingProjExtractor))
            .RegisterType<IProjectExtractor, SumingProjExtractor>(
                nameof(SumingProjExtractor))
            .RegisterSingleton<IProjectList, LibsList>(
                nameof(LibsList)
                , new InjectionConstructor(
                    Container.Resolve<IProjectExtractor>(
                        nameof(ResetingProjExtractor))
                    , Container.Resolve<ICodeData>(
                        nameof(ManyRefLibData))))
            .RegisterSingleton<IProjectList, AllProjList>(
                nameof(AllProjList)
                , new InjectionConstructor(
                    Container.Resolve<IProjectExtractor>(
                        nameof(ResetingProjExtractor))
                    , Container.Resolve<List<ICodeData>>()))
            .RegisterFactory<List<ICodeData>>("LogAppsFactory", (c) => 
                new List<ICodeData>
                {
                    c.Resolve<ICodeData>(nameof(ModernLogData))
                    , c.Resolve<ICodeData>(nameof(ModernWizardLogData))
                    , c.Resolve<ICodeData>(nameof(ModernMDILogData))
                    , c.Resolve<ICodeData>(nameof(ConsoleLogData))
                })
            .RegisterSingleton<IProjectList, LogAppsList>(
                nameof(LogAppsList)
                , new InjectionConstructor(
                    Container.Resolve<IProjectExtractor>(
                        nameof(SumingProjExtractor))
                    , Container.Resolve<List<ICodeData>>(
                        "LogAppsFactory")));
    }
}