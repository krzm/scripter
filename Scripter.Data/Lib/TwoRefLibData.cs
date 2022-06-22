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
        var lastUpd = new DateOnly(2022, 6, 22);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        CLIReader = Set(
            "cli-reader"
            , "CLIReader"
            , lastUpd
            , SetTests("CLIReader.Tests")
            , DIHelper
            , CLIHelper
            );
        DataToTable = Set(
            "datatotable"
            , "DataToTable"
            , lastUpd
            , SetTests("DataToTable.Tests")
            , DIHelper
            , ModelHelper
            );
    }
}