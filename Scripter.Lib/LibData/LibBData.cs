namespace Scripter;

public class LibBData 
    : LibAData
{
    protected ProjectDTO? DataToTable;
    protected ProjectDTO? CLIHelper;
    protected ProjectDTO? ConfigWrapper;
    
    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(DIHelper);
        DataToTable = Set(
            "datatotable"
            , "DataToTable"
            , new DateOnly(2022, 03, 16)
            , ModelHelper);
        CLIHelper = Set(
            "cli-helper"
            , "CLIHelper"
            , new DateOnly(2022, 03, 16)
            , DIHelper);
        ConfigWrapper = Set(
            "config-wrapper"
            , "Config.Wrapper"
            , new DateOnly(2022, 03, 18)
            , DIHelper);
    }
}