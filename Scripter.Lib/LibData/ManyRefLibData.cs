namespace Scripter;

public class ManyRefLibData 
    : TwoRefLibData
{
    protected ProjectDTO? SerilogWrapper;
    protected ProjectDTO? CRUDCommandHelper;
    protected ProjectDTO? CLIWizardHelper;
    protected ProjectDTO? CLIFramework;
    
    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        SerilogWrapper = Set(
            "serilog-wrapper"
            , "Serilog.Wrapper"
            , new DateOnly(2022, 3, 20)
            , DIHelper
            , CLIHelper
            , ConfigWrapper);
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(DataToTable);
        CRUDCommandHelper = Set(
            "crud-command-helper"
            , "CRUDCommandHelper"
            , new DateOnly(2022, 3, 20)
            , EFCoreHelper
            , CLIHelper
            , ModelHelper
            , DataToTable);
        ArgumentNullException.ThrowIfNull(CLIReader);
        CLIWizardHelper = Set(
            "cli-wizard-helper"
            , "CLIWizardHelper"
            , new DateOnly(2022, 3, 21)
            , EFCoreHelper
            , ModelHelper
            , CLIReader);
        CLIFramework = Set(
            "cli-framework"
            , "CLIFramework"
            , new DateOnly(2022, 4, 1)
            , DIHelper
            , CLIHelper
            , CRUDCommandHelper
            , CLIWizardHelper
            );
    }
}