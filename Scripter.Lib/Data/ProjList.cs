namespace Scripter;

public class ProjList
    : IProjectList
{
    private readonly IProjectExtractor projExtractor;
    private readonly ICodeData codeData;

    public List<ProjectDTO> Projects => 
        projExtractor.Projects;

    public ProjList(
        IProjectExtractor projExtractor
        , ICodeData codeData)
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
            codeData);
    }
}