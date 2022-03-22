namespace Scripter;

public class LibData 
    : LibCData
{
    protected ProjectDTO? SerilogWrapper;
    protected ProjectDTO? CRUDCommandHelper;
    protected ProjectDTO? CLIWizardHelper;
    protected ProjectDTO? CLIFramework;
    
    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(CLIReader);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        SerilogWrapper = Set(
            "serilog-wrapper"
            , "Serilog.Wrapper"
            , new DateOnly(2022, 3, 20)
            , DIHelper
            , CLIHelper
            , ConfigWrapper);
        CRUDCommandHelper = Set(
            "crud-command-helper"
            , "CRUDCommandHelper"
            , new DateOnly(2022, 3, 20)
            , ModelHelper
            , EFCoreHelper
            , CLIHelper
            , DataToTable);
        CLIWizardHelper = Set(
            "cli-wizard-helper"
            , "CLIWizardHelper"
            , new DateOnly(2022, 3, 21)
            , ModelHelper
            , EFCoreHelper
            , CLIReader);
        CLIFramework = Set(
            "cli-framework"
            , "CLIFramework"
            , new DateOnly(2022, 3, 21)
            , DIHelper
            , CLIHelper
            , CLIWizardHelper
            , CRUDCommandHelper);
    }
}