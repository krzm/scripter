namespace Scripter;

public class ProjectList : List<ProjectDTO>
{
    public ProjectList()
    {
        //shared core projects
        Add(new ProjectDTO("Core", "Core"));
        Add(new ProjectDTO("Console", "Console.Lib.TestApp"));
        //apps
        Add(new ProjectDTO("AppStarter", "AppStarter.ConsoleApp"));
        //log libs
        Add(new ProjectDTO("Log.Data", "Log.Data"));
        Add(new ProjectDTO("Log.Console.Lib", "Log.Console.Lib"));
        Add(new ProjectDTO("Log.Modern.Lib", "Log.Modern.Lib"));
        //log apps
        Add(new ProjectDTO("Log.ConsoleLib.ConsoleApp", "Log.ConsoleLib.ConsoleApp"));
        Add(new ProjectDTO("Log.Modern.Wizard.ConsoleApp", "Log.Modern.Wizard.ConsoleApp"));
        Add(new ProjectDTO("Log.Modern.ConsoleApp", "Log.Modern.ConsoleApp"));
        //inventory libs
        Add(new ProjectDTO("Inventory.Data", "Inventory.Data"));
        Add(new ProjectDTO("Inventory.Modern.Lib", "Inventory.Modern.Lib"));
        //inventory apps
        Add(new ProjectDTO("Inventory.Modern.ConsoleApp", "Inventory.Modern.ConsoleApp"));
    }
}