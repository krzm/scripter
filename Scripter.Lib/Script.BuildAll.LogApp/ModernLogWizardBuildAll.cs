namespace Scripter;

public class ModernLogWizardBuildAll 
    : ProjBuildAllScript
{
    public override string File => "ModernLogWizard.BuildAll.ps1";
    public override string Project => "Log.Modern.Wizard.ConsoleApp";

    public ModernLogWizardBuildAll(
        ICodeData appData) 
        : base(appData)
    {
    }
}