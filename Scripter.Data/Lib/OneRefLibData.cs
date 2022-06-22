using Scripter.Data.Helper;

namespace Scripter.Data;

public class OneRefLibData 
    : IndependantLibData
{
    protected ProjectDTO? CLIHelper;
    protected ProjectDTO? ConfigWrapper;
    protected ProjectDTO? SerilogWrapper;
    protected ProjectDTO? ModelHelper;
    
    protected override void SetAllData()
    {
        base.SetAllData();
        var lastUpd = new DateOnly(2022, 6, 22);
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
        SerilogWrapper = Set(
            "serilog-wrapper"
            , "Serilog.Wrapper"
            , lastUpd
            , DIHelper
            , CLIHelper
            , ConfigWrapper);
        ModelHelper = Set(
            "model-helper"
            , "ModelHelper"
            , lastUpd
            , DIHelper);
    }
}