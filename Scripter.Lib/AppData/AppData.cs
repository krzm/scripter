namespace Scripter;

public class AppData 
    : LibData
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

    protected override void SetAllData()
    {
        base.SetAllData();
        SetScripter();
        SetAppStarter();
        SetDiyBox();
        SetGameData();
    }

    private void SetScripter()
    {
        scripter = Set(
            "scripter"
            , "Scripter"
            , true
            , DataToTable
            , CommandDotNetUnityHelper
            , DIHelper
            , CommandDotNetUnityHelper);
    }

    private void SetAppStarter()
    {
        appStarterData = Set(
            "app-starter"
            , "AppStarter.Data"
            , ModelHelper
            , EFCoreHelper);

        appStarterModernLib = Set(
            "app-starter"
            , "AppStarter.Lib"
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

    private void SetDiyBox()
    {
        diyBoxCore = Set(
            "diy-box"
            , "DiyBox.Core"
            , CLIFramework);

        diyBoxCLIApp = Set(
            "diy-box"
            , "DiyBox.ConsoleApp"
            , true
            , DIHelper
            , CommandDotNetUnityHelper
            , CLIFramework);
    }

    private void SetGameData()
    {
        gameData = Set(
            "game-data"
            , "GameData.Data.Lib"
            , ModelHelper
            , EFCoreHelper);

        gameDataLib = Set(
            "game-data"
            , "GameData.Lib"
            , CLIHelper
            , EFCoreHelper
            , CLIReader
            , CRUDCommandHelper
            , CLIWizardHelper
            , CLIFramework
            , gameData);

        gameDataCLIApp = Set(
            "game-data"
            , "GameData.ConsoleApp"
            , true
            , ModelHelper
            , EFCoreHelper
            , DotNetExtension
            , CLIHelper
            , DataToTable
            , CLIReader
            , CRUDCommandHelper
            , DIHelper
            , CommandDotNetUnityHelper
            , CLIWizardHelper
            , CLIFramework
            , gameData
            , gameDataLib);
    }  
}