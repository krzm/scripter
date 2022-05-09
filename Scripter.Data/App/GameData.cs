namespace Scripter.Data;

public class GameData 
    : ManyRefLibData
{
    protected override void SetAllData()
    {
        base.SetAllData();
        SetGameData();
    }

    private void SetGameData()
    {
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        var gameData = Set(
            "game-data"
            , "GameData.Data.Lib"
            , new DateOnly(2022, 4, 9)
            , EFCoreHelper
            , ModelHelper
            );
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(CLIReader);
        ArgumentNullException.ThrowIfNull(CRUDCommandHelper);
        ArgumentNullException.ThrowIfNull(CLIWizardHelper);
        ArgumentNullException.ThrowIfNull(CLIFramework);
        var gameDataLib = Set(
            "game-data"
            , "GameData.Lib"
            , new DateOnly(2022, 4, 9)
            , EFCoreHelper
            , CLIHelper
            , CLIReader
            , CRUDCommandHelper
            , CLIWizardHelper
            , CLIFramework
            , gameData);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(DotNetExtension);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        var gameDataCLIApp = Set(
            "game-data"
            , "GameData.ConsoleApp"
            , true
            , new DateOnly(2022, 4, 9)
            , EFCoreHelper
            , DIHelper
            , DotNetExtension
            , CLIHelper
            , ConfigWrapper
            , ModelHelper
            , CLIReader
            , DataToTable
            , SerilogWrapper
            , CRUDCommandHelper
            , CLIWizardHelper
            , CLIFramework
            , gameData
            , gameDataLib);
    }  
}