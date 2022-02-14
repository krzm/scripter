namespace Scripter;

public class LibData : CodeData
{
    protected ProjectDTO? ModelHelper;
    protected ProjectDTO? EFCoreHelper;
    protected ProjectDTO? DotNetExtension;
    protected ProjectDTO? DotNetTool;
    protected ProjectDTO? CLIHelper;
    protected ProjectDTO? DataToTable;
    protected ProjectDTO? CLIReader;
    protected ProjectDTO? CommandDotNetUnity;
    protected ProjectDTO? DIHelper;
    protected ProjectDTO? CommandDotNetHelper;
    protected ProjectDTO? CRUDCommandHelper;
    protected ProjectDTO? CLIWizardHelper;
    protected ProjectDTO? CLIFramework;
    
    protected override void SetIndependentLib()
    {
        ModelHelper = Set(
            "model-helper", "ModelHelper");
        EFCoreHelper = Set(
            "efcore-helper", "EFCoreHelper");
        DotNetExtension = Set(
            "dotnet-extension", "DotNetExtension");
        DotNetTool = Set(
            "dotnet-tool", "DotNetTool");
    }

    protected override void SetOneDependancyLib()
    {
        CLIHelper = Set(
            "cli-helper", "CLIHelper"
            , ModelHelper);
        DataToTable = Set(
            "datatotable", "DataToTable"
            , ModelHelper);
        CLIReader = Set(
            "cli-reader", "CLIReader"
            , CLIHelper);
    }

    protected override void SetTwoDependancyLib()
    {
        CommandDotNetUnity = Set(
            "di-helper", "CommandDotNet.IoC.Unity"
            , CLIHelper, CLIReader);
        DIHelper = Set(
            "di-helper", "DIHelper"
            , CLIHelper, CLIReader);
        CommandDotNetHelper = Set(
            "commanddotnet-helper", "CommandDotNet.Helper"
            , DIHelper, CommandDotNetUnity);
    }

    protected override void SetManyDependancyLib()
    {
        CRUDCommandHelper = Set(
            "crud-command-helper", "CRUDCommandHelper"
            , ModelHelper, EFCoreHelper, CLIHelper, DataToTable);
        CLIWizardHelper = Set(
            "cli-wizard-helper", "CLIWizardHelper"
            , ModelHelper, EFCoreHelper, CLIHelper, CLIReader);
        CLIFramework = Set(
            "cli-framework", "CLIFramework"
            , CLIHelper, DIHelper, CRUDCommandHelper, CLIWizardHelper);
    }
}