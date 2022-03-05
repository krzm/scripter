namespace Scripter;

public class LibData 
    : LibCData
{
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
        CRUDCommandHelper = Set(
            "crud-command-helper"
            , "CRUDCommandHelper"
            , ModelHelper
            , EFCoreHelper
            , CLIHelper
            , DataToTable);
        CLIWizardHelper = Set(
            "cli-wizard-helper"
            , "CLIWizardHelper"
            , ModelHelper
            , EFCoreHelper
            , CLIHelper
            , CLIReader);
        CLIFramework = Set(
            "cli-framework"
            , "CLIFramework"
            , CLIHelper
            , DIHelper
            , CRUDCommandHelper
            , CLIWizardHelper);
    }
}