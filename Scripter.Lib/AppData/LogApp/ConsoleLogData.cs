namespace Scripter;

public class ConsoleLogData 
    : LogLibData
{
    private ProjectDTO? consoleLibCLIApp;

    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(DotNetExtension);
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(CLIReader);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(CRUDCommandHelper);
        ArgumentNullException.ThrowIfNull(CLIWizardHelper);
        ArgumentNullException.ThrowIfNull(CLIFramework);
        ArgumentNullException.ThrowIfNull(Data);
        ArgumentNullException.ThrowIfNull(Tables);
        ArgumentNullException.ThrowIfNull(InputWizards);
        ArgumentNullException.ThrowIfNull(ConsoleLibCmds);
        consoleLibCLIApp = Set(
            "log-console-lib-console-app"
            , "Log.ConsoleApp"
            , true
            , new DateOnly(2022, 3, 26)
            , ModelHelper
            , EFCoreHelper
            , DotNetExtension
            , DataToTable
            , ConfigWrapper
            , SerilogWrapper
            , CLIHelper
            , CLIReader
            , DIHelper
            , CRUDCommandHelper
            , CLIWizardHelper
            , CLIFramework
            , Data
            , Tables
            , InputWizards
            , ConsoleLibCmds
            );
    }
}