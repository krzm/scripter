namespace Scripter;

public class LibData : CodeData
{
    protected override void SetIndependentLib()
    {
        ModelHelper = Set(
            "model-helper", "ModelHelper");
        EFCoreHelper = Set(
            "efcore-helper", "EFCoreHelper");
        DotNetExtension = Set(
            "dotnet-extension", "DotNetExtension");
    }

    protected override void SetOneDependancyLib()
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

    protected override void SetTwoDependancyLib()
    {
        CommandDotNetUnity = Set(
            "di-helper", "CommandDotNet.IoC.Unity"
            , CliHelper, CliReader);
        DIHelper = Set(
            "di-helper", "DIHelper"
            , CliHelper, CliReader);
        CommandDotNetHelper = Set(
            "commanddotnet-helper", "CommandDotNet.Helper"
            , DIHelper, CommandDotNetUnity);
    }

    protected override void SetManyDependancyLib()
    {
        CrudCommandHelper = Set(
            "crud-command-helper", "CRUDCommandHelper"
            , ModelHelper, EFCoreHelper, CliHelper, DataToTable);
    }
}