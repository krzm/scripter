namespace Scripter;

public class ConsoleLogData 
    : ModernLogData
{
    private ProjectDTO? consoleLib;
    protected ProjectDTO? WizardLib;
    private ProjectDTO? consoleLibCLIApp;

    protected override void SetAllData()
    {
        base.SetAllData();
        SetConsoleLib();
    }

    private void SetConsoleLib()
    {
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(DotNetExtension);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(CLIWizardHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
        ArgumentNullException.ThrowIfNull(CRUDCommandHelper);
        ArgumentNullException.ThrowIfNull(dataLib);
        ArgumentNullException.ThrowIfNull(ModernLib);
        ArgumentNullException.ThrowIfNull(CLIFramework);
        ArgumentNullException.ThrowIfNull(CLIReader);
        ArgumentNullException.ThrowIfNull(DIHelper);
        consoleLib = Set(
            "log-console-lib", "Log.Console.Lib"
            , new DateOnly()
            , CLIHelper, CRUDCommandHelper, CLIWizardHelper, CLIFramework
            , dataLib, ModernLib);
        WizardLib = Set(
            "log-wizard-lib", "Log.Wizard.Lib"
            , new DateOnly()
            , EFCoreHelper, CLIHelper, CLIReader, CLIWizardHelper
            , dataLib);
        consoleLibCLIApp = Set(
            "log-console-lib-console-app", "Log.ConsoleApp"
            , true
            , new DateOnly()
            , ModelHelper, EFCoreHelper, DotNetExtension, DataToTable
            , CLIHelper, CLIReader, DIHelper, CRUDCommandHelper
            , CommandDotNetUnityHelper, CLIWizardHelper, CLIFramework, dataLib
            , WizardLib, ModernLib, consoleLib);
    }
}