namespace Scripter;

public class ProjectList : List<ProjectDTO>
{
    public ProjectList()
    {
        //shared core projects
        Add(new ProjectDTO("Core"));
        Add(new ProjectDTO("Console"));

        //log libs
        Add(new ProjectDTO("Log.Data"));
        Add(new ProjectDTO("Log.Console.Lib"));
        Add(new ProjectDTO("Log.Modern.Lib"));
        //log apps
        Add(new ProjectDTO("Log.ConsoleLib.ConsoleApp"));
        Add(new ProjectDTO("Log.Modern.ConsoleApp"));
        //inventory libs
        Add(new ProjectDTO("Inventory.Data"));
        Add(new ProjectDTO("Inventory.Modern.Lib"));
        //inventory apps
        Add(new ProjectDTO("Inventory.Modern.ConsoleApp"));
    }
}