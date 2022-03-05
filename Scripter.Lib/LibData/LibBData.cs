namespace Scripter;

public class LibBData 
    : LibAData
{
    protected ProjectDTO? CLIHelper;
    protected ProjectDTO? DataToTable;
    protected ProjectDTO? CLIReader;
    
    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(ModelHelper);
        CLIHelper = Set(
            "cli-helper"
            , "CLIHelper"
            , ModelHelper);
        DataToTable = Set(
            "datatotable"
            , "DataToTable"
            , ModelHelper);
        CLIReader = Set(
            "cli-reader"
            , "CLIReader"
            , CLIHelper);
    }
}