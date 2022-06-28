namespace Scripter.Data;

public class TestAppsData 
    : ManyRefLibData
{
    protected override void SetAllData()
    {
        base.SetAllData();
        var lastUpd = new DateOnly(2022, 6, 28);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(CLIReader);
        var cliFrameworkTestApp =  Set(
            "cli-framework"
            , "CLIFramework.TestApp"
            , isApp: true
            , lastUpd
            , DIHelper
            , CLIHelper
            , DataToTable
            , ModelHelper
            , CLIReader);
        var configTestApp = Set(
            "config-wrapper"
            , "Config.Wrapper.CLI.TestApp"
            , isApp: true
            , lastUpd
        );
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        var serilogTestApp = Set(
            "serilog-wrapper"
            , "Serilog.Wrapper.CLI.TestApp"
            , isApp: true
            , lastUpd
            , ConfigWrapper
        );
    }
}