namespace Scripter;

public class ProjectList : List<ProjectDTO>
{
    public ProjectList()
    {
        Add(new ProjectDTO("cli-helper", "CLIHelper"));
        Add(new ProjectDTO("cli-reader", "CLIReader"));
        Add(new ProjectDTO("di-helper", "CommandDotNet.IoC.Unity"));
        Add(new ProjectDTO("di-helper", "DIHelper"));
        Add(new ProjectDTO("commanddotnet-helper", "CommandDotNet.Helper"));
        Add(new ProjectDTO("model-helper", "ModelHelper"));
        Add(new ProjectDTO("datatotable", "DataToTable"));
        Add(new ProjectDTO("scripter", "Scripter"));

        Add(new ProjectDTO("efcore-helper", "EFCoreHelper"));
        Add(new ProjectDTO("log-data", "Log.Data"));
        
        Add(new ProjectDTO("crud-command-helper", "CRUDCommandHelper"));
        Add(new ProjectDTO("cli-wizard-helper", "CLIWizardHelper"));
        Add(new ProjectDTO("cli-framework", "CLIFramework"));
        Add(new ProjectDTO("cli-framework", "CLIFramework.TestApp"));

        Add(new ProjectDTO("log-wizard-lib", "Log.Wizard.Lib"));
        Add(new ProjectDTO("dotnet-extension", "DotNetExtension"));
        Add(new ProjectDTO("log-modern-lib", "Log.Modern.Lib"));
        Add(new ProjectDTO("log-console-lib", "Log.Console.Lib"));
        Add(new ProjectDTO("log-modern-consoleapp", "Log.Modern.ConsoleApp"));
        Add(new ProjectDTO("log-console-lib-console-app", "Log.ConsoleApp"));
        Add(new ProjectDTO("log-modern-mdi-consoleapp", "Log.Modern.MDI.ConsoleApp"));
        Add(new ProjectDTO("log-modern-wizard-consoleapp", "Log.Modern.Wizard.ConsoleApp"));

        Add(new ProjectDTO("app-starter", "AppStarter.ConsoleApp"));
        Add(new ProjectDTO("dotnet-tool", "DotNetTool"));

        Add(new ProjectDTO("inventory-data", "Inventory.Data"));
        Add(new ProjectDTO("inventory-wizard-lib", "Inventory.Wizard.Lib"));
        Add(new ProjectDTO("inventory-console-lib", "Inventory.Console.Lib"));
        
        Add(new ProjectDTO("inventory-modern-lib", "Inventory.Modern.Lib"));
        Add(new ProjectDTO("inventory-consolelib-consoleapp", "Inventory.ConsoleLib.ConsoleApp"));
        Add(new ProjectDTO("inventory-modern-consoleapp", "Inventory.Modern.ConsoleApp"));
        
        Add(new ProjectDTO("diy-box", "Diybox.ConsoleApp"));
        Add(new ProjectDTO("game-data", "GameData.ConsoleApp"));
        //Add(new ProjectDTO("", ""));
        //Add(new ProjectDTO("", ""));
        //Add(new ProjectDTO("", ""));
        //Add(new ProjectDTO("", ""));
        //Add(new ProjectDTO("", ""));
        //Add(new ProjectDTO("", ""));
        //Add(new ProjectDTO("", ""));
        //Add(new ProjectDTO("", ""));
        //Add(new ProjectDTO("", ""));
        //Add(new ProjectDTO("", ""));
        //Add(new ProjectDTO("", ""));
        //Add(new ProjectDTO("", ""));
        //Add(new ProjectDTO("", ""));
    }
}