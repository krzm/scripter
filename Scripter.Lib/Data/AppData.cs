namespace Scripter;

public class AppData : LibData
{
    private ProjectDTO? scripter;
    private ProjectDTO? appStarterData;
    private ProjectDTO? appStarterModernLib;
    private ProjectDTO? appStarterCLIApp;
    private ProjectDTO? diyBoxCore;
    private ProjectDTO? diyBoxCLIApp;
    private ProjectDTO? gameData;
    private ProjectDTO? gameDataLib;
    private ProjectDTO? gameDataCLIApp;

    protected override void SetApps()
    {
        SetScripter();
        SetAppStarter();
        SetDiyBox();
        SetGameData();
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
        appStarterCLIApp = Set(
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
        diyBoxCLIApp = Set(
            "diy-box", "DiyBox.ConsoleApp"
            , DIHelper, CommandDotNetHelper, CLIFramework);
    }

    private void SetGameData()
    {
        gameData = Set(
            "game-data", "GameData.Data.Lib"
            , ModelHelper, EFCoreHelper);
        gameDataLib = Set(
            "game-data", "GameData.Lib"
            , CLIHelper, EFCoreHelper, CLIReader, CRUDCommandHelper
            , CLIWizardHelper, CLIFramework, gameData);
        gameDataCLIApp = Set(
            "game-data", "GameData.ConsoleApp"
            , ModelHelper, EFCoreHelper, DotNetExtension, CLIHelper
            , DataToTable, CLIReader, CRUDCommandHelper, DIHelper
            , CommandDotNetHelper, CLIWizardHelper, CLIFramework, gameData
            , gameDataLib);
    }  
}