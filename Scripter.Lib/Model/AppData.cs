namespace Scripter;

public class AppData : LibData
{
    private ProjectDTO? scripter;
    private ProjectDTO? appStarterData;
    private ProjectDTO? appStarterModernLib;
    private ProjectDTO? appStarterConsoleApp;
    private ProjectDTO? diyBoxCore;
    private ProjectDTO? diyBoxConsoleApp;

    protected override void SetApps()
    {
        SetScripter();
        SetAppStarter();
        SetDiyBox();
    }

    private void SetScripter()
    {
        scripter = Set(
            "scripter", "Scripter"
            , DataToTable, CommandDotNetUnity, DIHelper, CommandDotNetHelper);
    }

    private void SetAppStarter()
    {
        appStarterData = Set(
            "app-starter", "AppStarter.Data"
            , ModelHelper, EFCoreHelper);
        appStarterModernLib = Set(
            "app-starter", "AppStarter.Lib"
            , ModelHelper, EFCoreHelper, DotNetExtension, CLIHelper
            , CLIReader, DotNetTool, DIHelper, DataToTable
            , CommandDotNetHelper, CRUDCommandHelper, CLIFramework, appStarterData);
        appStarterConsoleApp = Set(
            "app-starter", "AppStarter.ConsoleApp"
            , ModelHelper, EFCoreHelper, DotNetExtension, CLIHelper
            , CLIReader, DotNetTool, DIHelper, DataToTable
            , CommandDotNetHelper, CRUDCommandHelper, CLIFramework, appStarterData
            , appStarterModernLib);
    }  

    private void SetDiyBox()
    {
        diyBoxCore = Set(
            "diy-box", "DiyBox.Core"
            , CLIFramework);
        diyBoxConsoleApp = Set(
            "diy-box", "DiyBox.ConsoleApp"
            , DIHelper, CommandDotNetHelper, CLIFramework);
    }  
}