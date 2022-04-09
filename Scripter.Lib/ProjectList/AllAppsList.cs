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
        GetData(3, "DiyBox.ConsoleApp");
        GetData(4, "GameData.ConsoleApp");
        GetData(5, "Log.Modern.ConsoleApp");
        GetData(6, "Log.Modern.MDI.ConsoleApp");
        GetData(7, "Log.Modern.Wizard.ConsoleApp");
        GetData(8, "Log.ConsoleApp");
        GetData(9, "Inventory.Modern.ConsoleApp");
        GetData(10, "Inventory.ConsoleLib.ConsoleApp");
    }

    private void GetData(
        int i
        , string appName)
    {
        projExtractor.ExtractProjects(
            codeData[i][appName]);
    }
}