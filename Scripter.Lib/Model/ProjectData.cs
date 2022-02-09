namespace Scripter;

public class ProjectData : List<ProjectDTO>, IProjectData
{
    public ProjectData()
    {
        var modelHelper = new ProjectDTO("model-helper", "ModelHelper");
        var efCoreHelper =  new ProjectDTO("efcore-helper", "EFCoreHelper");
        var logData =  new ProjectDTO("log-data", "Log.Data"
            , new List<ProjectDTO> { modelHelper, efCoreHelper});
        Add(logData);
        var dotNetExtension = new ProjectDTO("dotnet-extension", "DotNetExtension");
        var cliHelper = new ProjectDTO("cli-helper", "CLIHelper"
            , new List<ProjectDTO> { modelHelper });
        var dataToTable = new ProjectDTO("datatotable", "DataToTable"
            , new List<ProjectDTO> { modelHelper });
        var crudCommandHelper = new ProjectDTO("crud-command-helper", "CRUDCommandHelper"
            , new List<ProjectDTO> { modelHelper, efCoreHelper, cliHelper, dataToTable });
        var logModernLib = new ProjectDTO("log-modern-lib", "Log.Modern.Lib"
             , new List<ProjectDTO> { modelHelper, efCoreHelper, logData, dotNetExtension, cliHelper, dataToTable, crudCommandHelper });
        Add(logModernLib);
        var cliReader = new ProjectDTO("cli-reader", "CLIReader"
            , new List<ProjectDTO> { cliHelper});
        var diHelper = new ProjectDTO("di-helper", "DIHelper"
            , new List<ProjectDTO> { cliHelper, cliReader });
        var commandDotNetUnity = new ProjectDTO("di-helper", "CommandDotNet.IoC.Unity");
        var commandDotNetHelper = new ProjectDTO("commanddotnet-helper", "CommandDotNet.Helper"
            , new List<ProjectDTO> { diHelper, commandDotNetUnity });
        var logModernConsoleApp = new ProjectDTO("log-modern-consoleapp", "Log.Modern.ConsoleApp"
            , new List<ProjectDTO> { 
                modelHelper, efCoreHelper, logData
                , dataToTable, crudCommandHelper, diHelper
                , commandDotNetHelper, logModernLib });
         Add(logModernConsoleApp);
    }
}