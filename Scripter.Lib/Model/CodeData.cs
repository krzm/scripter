namespace Scripter;

public class CodeData : CodeDataBase
{
    protected override void SetIndependent()
    {
        ModelHelper = Set(
            "model-helper", "ModelHelper");
        EFCoreHelper = Set(
            "efcore-helper", "EFCoreHelper");
        DotNetExtension = Set(
            "dotnet-extension", "DotNetExtension");
        CommandDotNetUnity = Set(
            "di-helper", "CommandDotNet.IoC.Unity");
    }

    protected override void SetOneDependancy()
    {
        CliHelper = Set(
            "cli-helper", "CLIHelper"
            , ModelHelper);
        DataToTable = Set(
            "datatotable", "DataToTable"
            , ModelHelper);
        CliReader = Set(
            "cli-reader", "CLIReader"
            , CliHelper);
    }

    protected override void SetTwoDependancy()
    {
        LogData = Set(
            "log-data", "Log.Data"
            , ModelHelper, EFCoreHelper);
        DiHelper = Set(
            "di-helper", "DIHelper"
            , CliHelper, CliReader);
        CommandDotNetHelper = Set(
            "commanddotnet-helper", "CommandDotNet.Helper"
            , DiHelper, CommandDotNetUnity);
    }

    protected override void SetManyDependancy()
    {
        CrudCommandHelper = Set(
            "crud-command-helper", "CRUDCommandHelper"
            , ModelHelper, EFCoreHelper, CliHelper, DataToTable);
        LogModernLib = Set(
            "log-modern-lib", "Log.Modern.Lib"
            , ModelHelper, EFCoreHelper, LogData, DotNetExtension
            , CliHelper, DataToTable, CrudCommandHelper);
        LogModernConsoleApp = Set(
            "log-modern-consoleapp", "Log.Modern.ConsoleApp"
            , ModelHelper, EFCoreHelper, LogData, DataToTable
            , CrudCommandHelper, DiHelper, CommandDotNetHelper, LogModernLib);
    }  
}