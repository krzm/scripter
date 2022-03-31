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
            , new DateOnly(2022, 3, 31)
            , ModelHelper
            , EFCoreHelper
            , DotNetExtension
            , CLIHelper
            , DataToTable
            , ConfigWrapper
            , SerilogWrapper
            , DIHelper
            , CRUDCommandHelper
            , CommandDotNetHelper
            , CommandDotNetMDIHelper
            , Data
            , Tables
            , ModernLibCmds);
    }
}