namespace Scripter;

public class ProjectList : List<ProjectDTO>
{
    public ProjectList()
    {
        Add(new ProjectDTO("cli-helper", "CLIHelper"));
        Add(new ProjectDTO("cli-reader", "CLIReader"));
        Add(new ProjectDTO("di-helper", "CommandDotNet.IoC.Unity"));
        Add(new ProjectDTO("di-helper", "DIHelper"));
    }
}