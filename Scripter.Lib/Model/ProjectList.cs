namespace Scripter;

public class ProjectList : List<ProjectDTO>
{
    public ProjectList()
    {
        Add(new ProjectDTO("Core"));
        Add(new ProjectDTO("Console"));
        Add(new ProjectDTO("Log.Modern.Lib"));
        Add(new ProjectDTO("Log.Data"));
        Add(new ProjectDTO("Log.Modern.ConsoleApp"));
    }
}