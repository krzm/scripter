using DIHelper.Unity;
using Scripter.Data;
using Scripter.Data.Helper;
using Unity;
using Unity.Injection;

namespace Scripter;

public class ProjectListSetB
    : UnityDependencySet
{
    public ProjectListSetB(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void Register()
    {
        RegisterAllProjList();
        RegisterAllAppsData();
        RegisterAllAppsList();
    }

    private void RegisterAllProjList()
    {
        Container.RegisterSingleton<IProjectList, AllProjList>(
            nameof(AllProjList)
            , new InjectionConstructor(
                Container.Resolve<IProjectExtractor>(
                    nameof(ResetingProjExtractor))
                , Container.Resolve<List<ICodeData>>()));
    }

    private void RegisterAllAppsData()
    {
        Container.RegisterFactory<List<ICodeData>>(
            "AllAppsFactory"
            , (c) =>
            new List<ICodeData>
            {
                c.Resolve<ICodeData>(nameof(ScripterData))
                , c.Resolve<ICodeData>(nameof(CliAppTemplateData))
                , c.Resolve<ICodeData>(nameof(AppStarterData))
                , c.Resolve<ICodeData>(nameof(CommanderData))
                , c.Resolve<ICodeData>(nameof(MicroservicesData))
                , c.Resolve<ICodeData>(nameof(DiyBoxData))
                , c.Resolve<ICodeData>(nameof(GameData))
                , c.Resolve<ICodeData>(nameof(ModernLogData))
                , c.Resolve<ICodeData>(nameof(ModernMDILogData))
                , c.Resolve<ICodeData>(nameof(ModernWizardLogData))
                , c.Resolve<ICodeData>(nameof(ConsoleLogData))
                , c.Resolve<ICodeData>(nameof(ModernInventoryAppData))
                , c.Resolve<ICodeData>(nameof(MyCliLibInventoryAppData))
            });
    }

    private void RegisterAllAppsList()
    {
        Container.RegisterSingleton<IProjectList, AllAppsList>(
            nameof(AllAppsList)
            , new InjectionConstructor(
                Container.Resolve<IProjectExtractor>(
                    nameof(SumingProjExtractor))
                , Container.Resolve<List<ICodeData>>(
                    "AllAppsFactory")));
    }
}