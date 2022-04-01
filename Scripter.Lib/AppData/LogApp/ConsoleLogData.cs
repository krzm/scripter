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
            , new DateOnly(2022, 4, 1)
            //IndependantLibData
            , EFCoreHelper
            , DIHelper
            , DotNetExtension
            //OneRefLibData
            , CLIHelper
            , ConfigWrapper
            , ModelHelper
            //TwoRefLibData
            , CLIReader
            , DataToTable
            //ManyRefLibData
            , SerilogWrapper
            , CRUDCommandHelper
            , CLIWizardHelper
            , CLIFramework
            //Log
            , Data
            , Tables
            , InputWizards
            , ConsoleLibCmds
            );
    }
}