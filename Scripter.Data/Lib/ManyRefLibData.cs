using Scripter.Data.Helper;

namespace Scripter.Data;

public class ManyRefLibData 
    : TwoRefLibData
{
    protected ProjectDTO? CRUDCommandHelper;
    protected ProjectDTO? CLIWizardHelper;
    protected ProjectDTO? CLIFramework;
    
    protected override void SetAllData()
    {
        base.SetAllData();
        var lastUpd = new DateOnly(2022, 6, 26);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(DataToTable);
        CRUDCommandHelper = Set(
            "crud-command-helper"
            , "CRUDCommandHelper"
            , lastUpd
            , EFCoreHelper
            , CLIHelper
            , ModelHelper
            , DataToTable);
        ArgumentNullException.ThrowIfNull(CLIReader);
        CLIWizardHelper = Set(
            "cli-wizard-helper"
            , "CLIWizardHelper"
            , lastUpd
            , EFCoreHelper
            , ModelHelper
            , CLIReader);
        ArgumentNullException.ThrowIfNull(DIHelper);
        CLIFramework = SetProjectDepsAndTests(
            "cli-framework"
            , "CLIFramework"
            , lastUpd
            , SetTests("CLIFramework.Tests")
            , DIHelper
            , CLIHelper
            , CRUDCommandHelper
            , CLIWizardHelper
            );
    }
}