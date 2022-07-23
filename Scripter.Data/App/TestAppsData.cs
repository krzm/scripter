namespace Scripter.Data;

public class TestAppsData 
    : AllLibsData
{
    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(CLIReader);
        var cliFrameworkTestApp =  Set(
            "cli-framework"
            , "CLIFramework.TestApp"
            , isApp: true
            , DIHelper
            , CLIHelper
            , DataToTable
            , ModelHelper
            , CLIReader);
    }
}