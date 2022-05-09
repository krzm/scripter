namespace Scripter.Data;

public class DiyBoxData 
    : ManyRefLibData
{
    protected override void SetAllData()
    {
        base.SetAllData();
        SetDiyBox();
    }
    
    private void SetDiyBox()
    {
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        var diyBoxCore = Set(
            "diy-box"
            , "DiyBox.Core"
            , new DateOnly(2022, 4, 22)
            , DIHelper
            , CLIHelper);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        ArgumentNullException.ThrowIfNull(CLIFramework);
        Set(
            "diy-box-cli-app"
            , "DiyBox.ConsoleApp"
            , true
            , new DateOnly(2022, 4, 22)
            , DIHelper
            , CLIHelper
            , ConfigWrapper
            , SerilogWrapper
            , CLIFramework
            , diyBoxCore);
        var diyBoxCmdDotNet = Set(
            "diy-box"
            , "DiyBox.CommandDotNet"
            , new DateOnly(2022, 4, 22));
        ArgumentNullException.ThrowIfNull(CommandDotNetHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetIoCUnity);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
        Set(
            "diy-box-modern-cli-app"
            , "DiyBox.Modern.CliApp"
            , true
            , new DateOnly(2022, 4, 22)
            , DIHelper
            , CLIHelper
            , ConfigWrapper
            , CommandDotNetHelper
            , CommandDotNetIoCUnity
            , CommandDotNetUnityHelper
            , SerilogWrapper
            , diyBoxCore
            , diyBoxCmdDotNet);
    }
}