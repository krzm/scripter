namespace Scripter;

public class ProjectExtractor : IProjectExtractor
{
    private List<ProjectDTO> projects;

    public List<ProjectDTO> Projects => projects;

    public ProjectExtractor()
    {
        this.projects = new List<ProjectDTO>();
    }

    public void ExtractProjects(params ICodeData[] codeData)
    {
        projects.Clear();
        foreach (var data in codeData)
        {
            foreach (var proj in data.Values)
            {
                SelectProjects(proj);
            }
        }
    }

    public void ExtractProjects(ProjectDTO project)
    {
        projects.Clear();
        SelectProjects(project);
    }

    private void SelectProjects(ProjectDTO project)
    {
        if (project.Dependencies != null)
        {
            foreach (var library in project.Dependencies)
            {
                if (library == null)
                    throw new NullReferenceException($"{library} is null");
                SelectProjects(library);
            }
        }
        if (IsNotYet(project))
            projects.Add(project);
    }

    private bool IsNotYet(ProjectDTO project)
    {
        return projects.Contains(project) == false;
    }
}