namespace Scripter;

public class ModernWizardLogData 
    : LogLibData
{
    private ProjectDTO? modernWizardCLIApp;

    protected override void SetAllData()
    {
        base.SetAllData();
        SetModernWizard();
    }
    
    private void SetModernWizard()
    {
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(DotNetExtension);
        
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(ModelHelper);

        ArgumentNullException.ThrowIfNull(CLIReader);
        ArgumentNullException.ThrowIfNull(DataToTable);

        ArgumentNullException.ThrowIfNull(CommandDotNetHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetIoCUnity);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);

        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        ArgumentNullException.ThrowIfNull(CRUDCommandHelper);
        ArgumentNullException.ThrowIfNull(CLIWizardHelper);

        ArgumentNullException.ThrowIfNull(Data);
        ArgumentNullException.ThrowIfNull(Tables);
        ArgumentNullException.ThrowIfNull(InputWizards);
        ArgumentNullException.ThrowIfNull(ModernLibCmds);
        modernWizardCLIApp = Set(
            "log-modern-wizard-consoleapp"
            , "Log.Modern.Wizard.ConsoleApp"
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
            //CommandDotNetLibData
            , CommandDotNetHelper
            , CommandDotNetIoCUnity
            , CommandDotNetUnityHelper
            //ManyRefLibData
            , SerilogWrapper
            , CRUDCommandHelper
            , CLIWizardHelper
            //Log
            , Data
            , Tables
            , InputWizards
            );
    }
}