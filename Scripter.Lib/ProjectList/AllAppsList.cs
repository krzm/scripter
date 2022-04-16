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
        GetData(1, "AppStarter.ConsoleApp");
        GetData(2, "Commander");
        GetData(3, "CommandsService");
        GetData(3, "PlatformService");
        GetData(4, "DiyBox.ConsoleApp");
        GetData(4, "DiyBox.Modern.CliApp");
        GetData(5, "GameData.ConsoleApp");
        GetData(6, "Log.Modern.ConsoleApp");
        GetData(7, "Log.Modern.MDI.ConsoleApp");
        GetData(8, "Log.Modern.Wizard.ConsoleApp");
        GetData(9, "Log.ConsoleApp");
        GetData(10, "Inventory.Modern.ConsoleApp");
        GetData(11, "Inventory.ConsoleLib.ConsoleApp");
    }

    private void GetData(
        int i
        , string appName)
    {
        projExtractor.ExtractProjects(
            codeData[i][appName]);
    }
}