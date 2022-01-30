namespace Scripter;

public class ProjectList : List<ProjectDTO>
{
    public ProjectList()
    {
        Add(new ProjectDTO("cli-helper", "CLIHelper"));
    }
}