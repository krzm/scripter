namespace Scripter;

public class GameData 
    : LibData
{
    private ProjectDTO? gameData;
    private ProjectDTO? gameDataLib;
    private ProjectDTO? gameDataCLIApp;

    protected override void SetAllData()
    {
        base.SetAllData();
        SetGameData();
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
            , new DateOnly()
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