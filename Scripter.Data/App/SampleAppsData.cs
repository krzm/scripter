namespace Scripter.Data;

public class SampleAppsData 
    : CommandDotNetLibData
{
    protected override void SetAllData()
    {
        base.SetAllData();
        var lastUpd = new DateOnly(2022, 6, 30);
        var commanddotnetexamples = SetProjAndTests(
            "commanddotnet-examples"
            , "CommandDotNet.Examples.App"
            , isApp: true
            , lastUpd
            , SetTest("CommandDotNet.Examples.Tests")
        );
    }
}