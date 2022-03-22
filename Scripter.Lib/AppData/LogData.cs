namespace Scripter;

public abstract class LogData 
    : LibData
{
    protected ProjectDTO? dataLib;
    
    protected override void SetAllData()
    {
        base.SetAllData();
        SetCommon();
    }

    private void SetCommon()
    {
        ArgumentNullException.ThrowIfNull(ModelHelper);
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        dataLib = Set(
            "log-data", "Log.Data"
            , new DateOnly()
            , ModelHelper, EFCoreHelper);
    }
}