using Scripter.Data.Helper;

namespace Scripter;

public class AllAppsList
    : IProjectList
{
    private readonly IProjectExtractor projExtractor;
    private readonly List<ICodeData> codeData;

    public List<ProjectDTO> Projects => 
        projExtractor.Projects;

    public AllAppsList(
        IProjectExtractor projExtractor
        , List<ICodeData> codeData)
    {
        this.projExtractor = projExtractor;
        this.codeData = codeData;
        ArgumentNullException.ThrowIfNull(this.projExtractor);
        ArgumentNullException.ThrowIfNull(this.codeData);
        Create();
    }

    private void Create()
    {
        GetData(0, "Scripter");
        GetData(1, "CLI.App.Template");
        GetData(2, "AppStarter.ConsoleApp");
        GetData(3, "Commander");
        GetData(4, "CommandsService");
        GetData(4, "PlatformService");
        GetData(5, "DiyBox.ConsoleApp");
        GetData(5, "DiyBox.Modern.CliApp");
        GetData(6, "GameData.ConsoleApp");
        GetData(7, "Log.Modern.ConsoleApp");
        GetData(8, "Log.Modern.MDI.ConsoleApp");
        GetData(9, "Log.Modern.Wizard.ConsoleApp");
        GetData(10, "Log.ConsoleApp");
        GetData(11, "Inventory.Modern.ConsoleApp");
        GetData(12, "Inventory.ConsoleLib.ConsoleApp");
    }

    private void GetData(
        int i
        , string appName)
    {
        projExtractor.ExtractProjects(
            codeData[i][appName]);
    }
}