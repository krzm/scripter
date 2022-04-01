namespace Scripter;

public class ModernLogData 
    : LogLibData
{
    private ProjectDTO? modernCLIApp;

    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(DIHelper);

        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(ModelHelper);

        ArgumentNullException.ThrowIfNull(DataToTable);

        ArgumentNullException.ThrowIfNull(CommandDotNetHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetIoCUnity);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);

        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        ArgumentNullException.ThrowIfNull(CRUDCommandHelper);
       
        ArgumentNullException.ThrowIfNull(Data);
        ArgumentNullException.ThrowIfNull(Tables);
        ArgumentNullException.ThrowIfNull(ModernLibCmds);
        modernCLIApp = Set(
            "log-modern-consoleapp"
            , "Log.Modern.ConsoleApp"
            , true
            , new DateOnly(2022, 4, 1)
            //IndependantLibData
            , EFCoreHelper
            , DIHelper
            //OneRefLibData
            , CLIHelper
            , ConfigWrapper
            , ModelHelper
            //TwoRefLibData
            , DataToTable
            //CommandDotNetLibData
            , CommandDotNetHelper
            , CommandDotNetIoCUnity
            , CommandDotNetUnityHelper
            //ManyRefLibData
            , SerilogWrapper
            , CRUDCommandHelper
            //Log
            , Data
            , Tables
            , ModernLibCmds);
    }
}