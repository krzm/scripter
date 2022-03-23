using DIHelper.Unity;
using Unity;
using Unity.Injection;

namespace Scripter;

public class AppDataSet 
    : UnityDependencySet
{
    public AppDataSet(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void Register()
    {
        Container.RegisterSingleton<ICodeData, LibData>(
            nameof(LibData));

        Container.RegisterSingleton<ICodeData, CommanderData>(
            nameof(CommanderData));
        Container.RegisterSingleton<ICodeData, ScripterData>(
            nameof(ScripterData));
        Container.RegisterSingleton<ICodeData, AppStarterData>(
            nameof(AppStarterData));
        Container.RegisterSingleton<ICodeData, DiyBoxData>(
            nameof(DiyBoxData));
        Container.RegisterSingleton<ICodeData, GameData>(
            nameof(GameData));
        Container.RegisterSingleton<ICodeData, ConsoleLogData>(
            nameof(ConsoleLogData));
        Container.RegisterSingleton<ICodeData, ModernMDILogData>(
            nameof(ModernMDILogData));
        Container.RegisterSingleton<ICodeData, ModernWizardLogData>(
            nameof(ModernWizardLogData));
        Container.RegisterSingleton<ICodeData, ModernLogData>(
            nameof(ModernLogData));
        Container.RegisterSingleton<ICodeData, ConsoleInventoryData>(
            nameof(ConsoleInventoryData));
        Container.RegisterSingleton<ICodeData, ModernInventoryData>(
            nameof(ModernInventoryData));

        Container.RegisterType<IProjectExtractor, ProjectExtractor>();
        Container.RegisterSingleton<IProjectList, ProjList>(
            nameof(ProjList)
            , new InjectionConstructor(
                Container.Resolve<IProjectExtractor>()
                , Container.Resolve<ICodeData>(
                    nameof(LibData))));
        Container.RegisterSingleton<IProjectList, AllProjList>(
            nameof(AllProjList));
    }
}