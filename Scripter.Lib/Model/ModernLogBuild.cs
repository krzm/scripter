namespace Scripter;

public class ModernLogBuild : IModernLogBuild
{
    public ProjectDTO App => new ProjectDTO("log-modern-consoleapp", "Log.Modern.ConsoleApp");

    public List<ProjectDTO> Libs => new List<ProjectDTO>
    {
        new ProjectDTO("model-helper", "ModelHelper"),
        new ProjectDTO("efcore-helper", "EFCoreHelper"),
        new ProjectDTO("log-data", "Log.Data"),

        new ProjectDTO("cli-helper", "CLIHelper"),
        new ProjectDTO("crud-command-helper", "CRUDCommandHelper"),
        new ProjectDTO("dotnet-extension", "DotNetExtension"),
        new ProjectDTO("datatotable", "DataToTable"),
        new ProjectDTO("log-modern-lib", "Log.Modern.Lib"),

        new ProjectDTO("di-helper", "CommandDotNet.IoC.Unity"),
        new ProjectDTO("di-helper", "DIHelper"),
        new ProjectDTO("commanddotnet-helper", "CommandDotNet.Helper"),
        new ProjectDTO("log-modern-consoleapp", "Log.Modern.ConsoleApp")
    };
}