namespace Scripter.Data;

public class GameData 
    : ManyRefLibData
{
    protected override void SetAllData()
    {
        base.SetAllData();
        var lastUpd = new DateOnly(2022, 6, 26);
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        var gameData = Set(
            "game-data"
            , "GameData.Data.Lib"
            , lastUpd
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
            , lastUpd
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
            , isApp: true
            , lastUpd
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