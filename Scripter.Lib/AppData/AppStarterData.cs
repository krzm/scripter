namespace Scripter;

public class AppStarterData 
    : ManyRefLibData
{
    private ProjectDTO? appStarterData;
    private ProjectDTO? appStarterModernLib;
    private ProjectDTO? appStarterCLIApp;

    protected override void SetAllData()
    {
        base.SetAllData();
        SetAppStarter();
    }
    
    private void SetAppStarter()
    {
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(DotNetExtension);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(CLIReader);
        ArgumentNullException.ThrowIfNull(DotNetTool);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
        ArgumentNullException.ThrowIfNull(CRUDCommandHelper);
        ArgumentNullException.ThrowIfNull(CLIFramework);
        appStarterData = Set(
            "app-starter"
            , "AppStarter.Data"
            , new DateOnly()
            , ModelHelper
            , EFCoreHelper);

        appStarterModernLib = Set(
            "app-starter"
            , "AppStarter.Lib"
            , new DateOnly()
            , ModelHelper
            , EFCoreHelper
            , DotNetExtension
            , CLIHelper
            , CLIReader
            , DotNetTool
            , DIHelper
            , DataToTable
            , CommandDotNetUnityHelper
            , CRUDCommandHelper
            , CLIFramework
            , appStarterData);

        appStarterCLIApp = Set(
            "app-starter"
            , "AppStarter.ConsoleApp"
            , true
            , new DateOnly()
            , ModelHelper
            , EFCoreHelper
            , DotNetExtension
            , CLIHelper
            , CLIReader
            , DotNetTool
            , DIHelper
            , DataToTable
            , CommandDotNetUnityHelper
            , CRUDCommandHelper
            , CLIFramework
            , appStarterData
            , appStarterModernLib);
    }
}