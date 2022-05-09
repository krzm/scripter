using Scripter.Data.Helper;

namespace Scripter.Data;

public abstract class LogLibData 
    : ManyRefLibData
{
    protected ProjectDTO? Data;
    protected ProjectDTO? Tables;
    protected ProjectDTO? ConsoleLibCmds;
    protected ProjectDTO? InputWizards;
    protected ProjectDTO? ModernLibCmds;

    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        Data = Set(
            "log-data"
            , "Log.Data"
            , new DateOnly(2022, 3, 22)
            , EFCoreHelper
            , ModelHelper
            );
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(DataToTable);
        Tables = Set(
            "log-table"
            , "Log.Table"
            , new DateOnly(2022, 4, 1)
            , DIHelper
            , ModelHelper
            , DataToTable
            , Data
        );
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(CRUDCommandHelper);
        ArgumentNullException.ThrowIfNull(CLIWizardHelper);
        ArgumentNullException.ThrowIfNull(CLIFramework);
        ConsoleLibCmds = Set(
            "log-console-lib"
            , "Log.Console.Lib"
            , new DateOnly(2022, 4, 1)
            , EFCoreHelper
            , CLIHelper
            , DataToTable
            , CRUDCommandHelper
            , CLIWizardHelper
            , CLIFramework
            , Data
            );
        ArgumentNullException.ThrowIfNull(CLIReader);
        InputWizards = Set(
            "log-wizard-lib"
            , "Log.Wizard.Lib"
            , new DateOnly(2022, 3, 26)
            , EFCoreHelper
            , CLIReader
            , CLIWizardHelper
            , Data
            );
        ArgumentNullException.ThrowIfNull(DotNetExtension);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ModernLibCmds = Set(
            "log-modern-lib"
            , "Log.Modern.Lib"
            , new DateOnly(2022, 4, 1)
            , EFCoreHelper
            , DIHelper
            , DotNetExtension
            , CLIHelper
            , ModelHelper
            , DataToTable
            , CRUDCommandHelper
            , Data
            );
    }   
}