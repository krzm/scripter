namespace Scripter;

public class ProjectList : List<ProjectDTO>
{
    public ProjectList()
    {
        //shared
        Add(new ProjectDTO("Core", "Core"));
        Add(new ProjectDTO("Console", "Console.Lib.TestApp"));
        Add(new ProjectDTO("DataToTable", "DataToTable"));
        Add(new ProjectDTO("CLIHelper", "CLIHelper"));
        Add(new ProjectDTO("DIHelper", "DIHelper"));

        //apps
        Add(new ProjectDTO("AppStarter", "AppStarter.ConsoleApp"));
        Add(new ProjectDTO("Commander", "Commander"));
        Add(new ProjectDTO("DiyBox", "ConsoleApp"));
        Add(new ProjectDTO("GameData", "GameData.ConsoleApp"));
        Add(new ProjectDTO("GitPath", "GitPath.ConsoleApp"));
        Add(new ProjectDTO("Scripter", "Scripter"));
        Add(new ProjectDTO("TimCoRetailManager", "TRMDesktopUI"));
        Add(new ProjectDTO("TimCoRetailManagerDevOps", "TRMDesktopUI"));

        //log libs
        Add(new ProjectDTO("Log.Data", "Log.Data"));
        Add(new ProjectDTO("Log.Console.Lib", "Log.Console.Lib"));
        Add(new ProjectDTO("Log.Modern.Lib", "Log.Modern.Lib"));

        //log apps
        Add(new ProjectDTO("Log.ConsoleLib.ConsoleApp", "Log.ConsoleApp"));
        Add(new ProjectDTO("Log.Modern.Wizard.ConsoleApp", "Log.Modern.Wizard.ConsoleApp"));
        Add(new ProjectDTO("Log.Modern.MDI.ConsoleApp", "Log.Modern.MDI.ConsoleApp"));
        Add(new ProjectDTO("Log.Modern.ConsoleApp", "Log.Modern.ConsoleApp"));
        
        //inventory libs
        Add(new ProjectDTO("Inventory.Data", "Inventory.Data"));
        Add(new ProjectDTO("Inventory.Console.Lib", "Inventory.Console.Lib"));
        Add(new ProjectDTO("Inventory.Modern.Lib", "Inventory.Modern.Lib"));

        //inventory apps
        Add(new ProjectDTO("Inventory.ConsoleLib.ConsoleApp", "Inventory.ConsoleLib.ConsoleApp"));
        Add(new ProjectDTO("Inventory.Modern.ConsoleApp", "Inventory.Modern.ConsoleApp"));
    }
}