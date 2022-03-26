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
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
        ArgumentNullException.ThrowIfNull(CRUDCommandHelper);
        ArgumentNullException.ThrowIfNull(Data);
        ArgumentNullException.ThrowIfNull(ModernLibCmds);
        modernMDICLIApp =  Set(
            "log-modern-mdi-consoleapp"
            , "Log.Modern.MDI.ConsoleApp"
            , true
            , new DateOnly()
            , ModelHelper
            , EFCoreHelper
            , DotNetExtension
            , CLIHelper
            , DataToTable
            , DIHelper
            , CommandDotNetUnityHelper
            , CRUDCommandHelper
            , Data
            , ModernLibCmds
            );
    }
}