using Scripter.Data.Helper;
using Scripter.Data;

namespace Scripter;

public class AllAppsList
    : IProjectList
{
    private readonly IProjectExtractor projExtractor;
    private readonly IDictionary<string, ICodeData> codeData;

    public List<ProjectDTO> Projects => 
        projExtractor.Projects;

    public AllAppsList(
        IProjectExtractor projExtractor
        , IDictionary<string, ICodeData> codeData)
    {
        this.projExtractor = projExtractor;
        this.codeData = codeData;
        ArgumentNullException.ThrowIfNull(this.projExtractor);
        ArgumentNullException.ThrowIfNull(this.codeData);
        Create();
    }

    private void Create()
    {
        GetData(nameof(ScripterData), "Scripter");
        GetData(nameof(CliAppTemplateData), "CLI.App.Template");
        GetData(nameof(TestAppsData), "CLIFramework.TestApp");
        GetData(nameof(WrapperAppsData), "Config.Wrapper.CLI.TestApp");
        GetData(nameof(WrapperAppsData), "Serilog.Wrapper.CLI.TestApp");
        GetData(nameof(SampleAppsData), "CommandDotNet.Examples.App");
        GetData(nameof(SmallAppsData), "Refactor.App");
        GetData(nameof(SmallAppsData), "GitPath.ConsoleApp");
        GetData(nameof(AppStarterData), "AppStarter.ConsoleApp");
        GetData(nameof(CommanderData), "Commander");
        GetData(nameof(MicroservicesData), "CommandsService");
        GetData(nameof(MicroservicesData), "PlatformService");
        GetData(nameof(DiyBoxData), "DiyBox.ConsoleApp");
        GetData(nameof(DiyBoxData), "DiyBox.Modern.CliApp");
        GetData(nameof(GameData), "GameData.ConsoleApp");
        GetData(nameof(ModernLogData), "Log.Modern.ConsoleApp");
        GetData(nameof(ModernMDILogData), "Log.Modern.MDI.ConsoleApp");
        GetData(nameof(ModernWizardLogData), "Log.Modern.Wizard.ConsoleApp");
        GetData(nameof(ConsoleLogData), "Log.ConsoleApp");
        GetData(nameof(ModernInventoryAppData), "Inventory.Modern.ConsoleApp");
        GetData(nameof(MyCliLibInventoryAppData), "Inventory.ConsoleLib.ConsoleApp");
        GetData(nameof(ShapeEngineData), "Canvas.App");
        GetData(nameof(ShapeEngineData), "Pool.App");
    }

    private void GetData(
        string dataSetName
        , string appName)
    {
        projExtractor.ExtractProjects(
            codeData[dataSetName][appName]);
    }
}