namespace Scripter;

public class TwoRefLibData 
    : CommandDotNetLibData
{
    protected ProjectDTO? CLIReader;
    protected ProjectDTO? DataToTable;
    
    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(DIHelper);
        CLIReader = Set(
            "cli-reader"
            , "CLIReader"
            , new DateOnly(2022, 03, 16)
            , CLIHelper
            , DIHelper);
        DataToTable = Set(
            "datatotable"
            , "DataToTable"
            , new DateOnly(2022, 03, 27)
            , ModelHelper
            , DIHelper);
    }
}