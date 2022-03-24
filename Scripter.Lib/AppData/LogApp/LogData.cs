namespace Scripter;

public abstract class LogData 
    : LibData
{
    protected ProjectDTO? DataLib;
    
    protected override void SetAllData()
    {
        base.SetAllData();
        SetCommon();
    }

    private void SetCommon()
    {
        ArgumentNullException.ThrowIfNull(EFCoreHelper);
        ArgumentNullException.ThrowIfNull(ModelHelper);
        DataLib = Set(
            "log-data"
            , "Log.Data"
            , new DateOnly(2022, 3, 22)
            , EFCoreHelper
            , ModelHelper);
    }
}