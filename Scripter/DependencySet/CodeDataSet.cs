using DIHelper.Unity;
using Scripter.Inventory;
using Unity;

namespace Scripter;

public class CodeDataSet 
    : UnityDependencySet
{
    public CodeDataSet(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void Register()
    {
        Container
            .RegisterSingleton<ICodeData, ManyRefLibData>(
                nameof(ManyRefLibData))
            .RegisterSingleton<ICodeData, ScripterData>(
                nameof(ScripterData))
            .RegisterSingleton<ICodeData, AppStarterData>(
                nameof(AppStarterData))
             .RegisterSingleton<ICodeData, CommanderData>(
                nameof(CommanderData))
            .RegisterSingleton<ICodeData, DiyBoxData>(
                nameof(DiyBoxData))
            .RegisterSingleton<ICodeData, GameData>(
                nameof(GameData))
            .RegisterSingleton<ICodeData, ModernLogData>(
                nameof(ModernLogData))
            .RegisterSingleton<ICodeData, ModernMDILogData>(
                nameof(ModernMDILogData))
            .RegisterSingleton<ICodeData, ModernWizardLogData>(
                nameof(ModernWizardLogData))
            .RegisterSingleton<ICodeData, ConsoleLogData>(
                nameof(ConsoleLogData))
            .RegisterSingleton<ICodeData, Inventory.ModernAppData>(
                nameof(Inventory.ModernAppData))
            .RegisterSingleton<ICodeData, Inventory.CliLibAppData>(
                nameof(Inventory.CliLibAppData));
    }
}