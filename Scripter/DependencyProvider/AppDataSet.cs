using DIHelper.Unity;
using Unity;

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
        SetData();
    }

    private void SetData()
    {
        Container.RegisterSingleton<ICodeData, CommanderData>(nameof(CommanderData));

        Container.RegisterSingleton<ICodeData, LibData>(nameof(LibData));
        Container.RegisterSingleton<ICodeData, AppData>(nameof(AppData));
        Container.RegisterSingleton<ICodeData, LogData>(nameof(LogData));
        Container.RegisterSingleton<ICodeData, InventoryData>(nameof(InventoryData));

        Container.RegisterType<IProjectExtractor, ProjectExtractor>();
        
        Container.RegisterSingleton<IProjectList, ProjectList>();
    }
}