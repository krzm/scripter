using Scripter.Data.Helper;

namespace Scripter.Data;

public class ScripterData 
    : ManyRefLibData
{
    private ProjectDTO? scripter;

    protected override void SetAllData()
    {
        base.SetAllData();
        SetScripter();
    }

    private void SetScripter()
    {
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(DataToTable);
        ArgumentNullException.ThrowIfNull(CommandDotNetHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        scripter = Set(
            repo: "scripter"
            , project: "Scripter"
            , isApp: true
            , lastCheck: new DateOnly(2022, 4, 1)
            , DIHelper
            , ConfigWrapper
            , DataToTable
            , CommandDotNetHelper
            , CommandDotNetUnityHelper
            , SerilogWrapper
            );
    }
}