namespace Scripter.Data;

public class WrapperAppsData 
    : CommandDotNetLibData
{
    protected override void SetAllData()
    {
        var lastUpd = new DateOnly(2022, 6, 29);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
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
        var commanddotnetexamples = SetProjAndTests(
            "commanddotnet-examples"
            , "CommandDotNet.Examples.App"
            , isApp: true
            , lastUpd
            , SetTest("CommandDotNet.Examples.Tests")
        );
    }
}