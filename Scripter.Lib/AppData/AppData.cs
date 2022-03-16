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
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
        ArgumentNullException.ThrowIfNull(DIHelper);
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
        ArgumentNullException.ThrowIfNull(CLIFramework);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
        diyBoxCore = Set(
            "diy-box"
            , "DiyBox.Core"
            , new DateOnly()
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
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(CLIReader);
        ArgumentNullException.ThrowIfNull(CRUDCommandHelper);
        ArgumentNullException.ThrowIfNull(CLIWizardHelper);
        ArgumentNullException.ThrowIfNull(CLIFramework);
        ArgumentNullException.ThrowIfNull(DotNetExtension);
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
        gameData = Set(
            "game-data"
            , "GameData.Data.Lib"
            , new DateOnly()
            , ModelHelper
            , EFCoreHelper);

        gameDataLib = Set(
            "game-data"
            , "GameData.Lib"
            , new DateOnly()
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