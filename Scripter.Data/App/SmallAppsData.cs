namespace Scripter.Data;

public class SmallAppsData 
    : ManyRefLibData
{
    protected override void SetAllData()
    {
        var lastUpd = new DateOnly(2022, 6, 29);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(CommandDotNetHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        Set(
            "refactor-app"
            , "Refactor.App"
            , isApp: true
            , lastUpd
            , DIHelper
            , ConfigWrapper
            , CommandDotNetHelper
            , CommandDotNetUnityHelper
            , SerilogWrapper);
    }
}