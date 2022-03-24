namespace Scripter;

public class ModernWizardLogData 
    : ConsoleLogData
{
    private ProjectDTO? modernWizardCLIApp;

    protected override void SetAllData()
    {
        base.SetAllData();
        SetModernWizard();
    }
    
    private void SetModernWizard()
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
        ArgumentNullException.ThrowIfNull(CLIReader);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(WizardLib);
        modernWizardCLIApp = Set(
            "log-modern-wizard-consoleapp", "Log.Modern.Wizard.ConsoleApp"
            , true
            , new DateOnly()
            , ModelHelper, EFCoreHelper, DotNetExtension, CLIHelper
            , CLIReader, DataToTable, DIHelper, CommandDotNetUnityHelper
            , CLIWizardHelper, CRUDCommandHelper, dataLib, WizardLib
            , ModernLib);
    }
}