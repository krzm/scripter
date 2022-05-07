namespace Scripter;

public class OneRefLibData 
    : IndependantLibData
{
    protected ProjectDTO? CLIHelper;
    protected ProjectDTO? ConfigWrapper;
    protected ProjectDTO? ModelHelper;
    
    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(DIHelper);
        CLIHelper = Set(
            "cli-helper"
            , "CLIHelper"
            , new DateOnly(2022, 3, 16)
            , DIHelper);
        ConfigWrapper = Set(
            "config-wrapper"
            , "Config.Wrapper"
            , new DateOnly(2022, 3, 18)
            , DIHelper);
        ModelHelper = Set(
            "model-helper"
            , "ModelHelper"
            , new DateOnly(2022, 3, 22)
            , DIHelper);
    }
}