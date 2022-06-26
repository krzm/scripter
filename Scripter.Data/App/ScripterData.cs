namespace Scripter.Data;

public class ScripterData 
    : ManyRefLibData
{
    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetHelper);
        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        var scripter = SetProjectDepsAndTests(
            repo: "scripter"
            , project: "Scripter"
            , isApp: true
            , lastCheck: new DateOnly(2022, 6, 26)
            , SetTests("Scripter.Lib.Tests")
            , DIHelper
            , ConfigWrapper
            , DataToTable
            , CommandDotNetUnityHelper
            , CommandDotNetHelper
            , SerilogWrapper
            );
    }
}