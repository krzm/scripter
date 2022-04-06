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
        appStarterData = Set(
            "app-starter"
            , "AppStarter.Data"
            , new DateOnly(2022, 4, 6)
            , EFCoreHelper
            , ModelHelper
            );
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(CLIReader);
        ArgumentNullException.ThrowIfNull(DotNetTool);
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(CLIFramework);
        appStarterModernLib = Set(
            "app-starter"
            , "AppStarter.Lib"
            , new DateOnly(2022, 4, 6)
            , EFCoreHelper
            , DotNetTool
            , CLIHelper
            , ModelHelper
            , CLIReader
            , DataToTable
            , CLIFramework
            );
        ArgumentNullException.ThrowIfNull(DotNetExtension);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        appStarterCLIApp = Set(
            "app-starter"
            , "AppStarter.ConsoleApp"
            , true
            , new DateOnly(2022, 4, 6)
            , EFCoreHelper
            , DIHelper
            , DotNetExtension
            , DotNetTool
            , CLIHelper
            , ConfigWrapper
            , ModelHelper
            , CLIReader
            , DataToTable
            , SerilogWrapper
            , CLIFramework
            , appStarterData
            , appStarterModernLib
            );
    }
}