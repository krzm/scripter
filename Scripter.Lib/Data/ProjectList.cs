namespace Scripter;

public class ProjectList
    : IProjectList
{
    private readonly IProjectExtractor projectExtractor;
    private readonly List<ICodeData> codeData;

    public List<ProjectDTO> Projects => projectExtractor.Projects;

    public ProjectList(
        IProjectExtractor projectExtractor
        , List<ICodeData> codeData)
    {
        this.projectExtractor = projectExtractor;
        this.codeData = codeData;
        Create();
    }

    private void Create()
    {
        projectExtractor.ExtractProjects(codeData.ToArray());
    }
}