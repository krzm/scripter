using Scripter.Data.Helper;

namespace Scripter.Data;

public class ManyRefLibData 
    : TwoRefLibData
{
    protected ProjectDTO? SerilogWrapper;
    protected ProjectDTO? CLIWizardHelper;
    protected ProjectDTO? CRUDCommandHelper;
    protected ProjectDTO? CLIFramework;
    
    protected override void SetAllData()
    {
        base.SetAllData();
        var lastUpd = new DateOnly(2022, 7, 23);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(CLIReader);
        ArgumentNullException.ThrowIfNull(DataToTable);
        SerilogWrapper = Set(
            "serilog-wrapper"
            , "Serilog.Wrapper"
            , lastUpd
            , DIHelper
            , CLIHelper
            , ConfigWrapper);
        CLIWizardHelper = Set(
            "cli-wizard-helper"
            , "CLIWizardHelper"
            , lastUpd
            , EFCoreHelper
            , ModelHelper
            , CLIReader);
        CRUDCommandHelper = Set(
            "crud-command-helper"
            , "CRUDCommandHelper"
            , lastUpd
            , EFCoreHelper
            , CLIHelper
            , ModelHelper
            , DataToTable);
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