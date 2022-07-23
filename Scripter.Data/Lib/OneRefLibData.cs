using Scripter.Data.Helper;

namespace Scripter.Data;

public class OneRefLibData 
    : IndependantLibData
{
    protected ProjectDTO? CLIHelper;
    protected ProjectDTO? ConfigWrapper;
    protected ProjectDTO? EFCoreHelper;
    protected ProjectDTO? ModelHelper;
    
    protected override void SetAllData()
    {
        base.SetAllData();
        var lastUpd = new DateOnly(2022, 7, 23);
        ArgumentNullException.ThrowIfNull(DIHelper);
        CLIHelper = SetProjectDepsAndTests(
            "cli-helper"
            , "CLIHelper"
            , lastUpd
            , SetTests("CLIHelper.Tests")
            , DIHelper);
        ConfigWrapper = SetProjectDepsAndTests(
            "config-wrapper"
            , "Config.Wrapper"
            , lastUpd
            , SetTests("Config.Wrapper.Tests")
            , DIHelper);
        EFCoreHelper = Set(
            "efcore-helper"
            , "EFCore.Helper"
            , lastUpd);
        ModelHelper = Set(
            "model-helper"
            , "ModelHelper"
            , lastUpd
            , DIHelper);
    }
}