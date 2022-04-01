namespace Scripter;

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
        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        ArgumentNullException.ThrowIfNull(CommandDotNetHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
        ArgumentNullException.ThrowIfNull(DataToTable);
        scripter = Set(
            "scripter"
            , "Scripter"
            , true
            , new DateOnly(2022, 4, 1)
            //IndependantLibData
            , DIHelper
            //OneRefLibData
            , ConfigWrapper
            //TwoRefLibData
            , DataToTable
            //CommandDotNetLibData
            , CommandDotNetHelper
            , CommandDotNetUnityHelper
            //ManyRefLibData
            , SerilogWrapper
            );
    }
}