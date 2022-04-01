namespace Scripter;

public class ModernMDILogData 
    : LogLibData
{
    private ProjectDTO? modernMDICLIApp;

    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(DotNetExtension);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(CRUDCommandHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetMDIHelper);
        ArgumentNullException.ThrowIfNull(Data);
        ArgumentNullException.ThrowIfNull(Tables);
        ArgumentNullException.ThrowIfNull(ModernLibCmds);
        modernMDICLIApp = Set(
            "log-modern-mdi-consoleapp"
            , "Log.Modern.MDI.ConsoleApp"
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
            , DataToTable
            //CommandDotNetLibData
            , CommandDotNetHelper
            , CommandDotNetMDIHelper
            //ManyRefLibData
            , SerilogWrapper
            , CRUDCommandHelper
            //Log
            , Data
            , Tables
            , ModernLibCmds);
    }
}