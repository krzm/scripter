namespace Scripter;

public class AllProjList
    : IProjectList
{
    private readonly IProjectExtractor projExtractor;
    private readonly List<ICodeData> codeData;

    public List<ProjectDTO> Projects => 
        projExtractor.Projects;

    public AllProjList(
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
        projExtractor.ExtractProjects(
            codeData.ToArray());
    }
}