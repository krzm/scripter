using Scripter.Data.Helper;

namespace Scripter.Data;

public class TwoRefLibData 
    : CommandDotNetLibData
{
    protected ProjectDTO? CLIReader;
    protected ProjectDTO? DataToTable;
    
    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        CLIReader = Set(
            "cli-reader"
            , "CLIReader"
            , new DateOnly(2022, 4, 1)
            , DIHelper
            , CLIHelper
            );
        DataToTable = Set(
            "datatotable"
            , "DataToTable"
            , new DateOnly(2022, 4, 1)
            , DIHelper
            , ModelHelper
            );
    }
}