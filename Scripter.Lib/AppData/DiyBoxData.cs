namespace Scripter;

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
        var diyBoxCore = Set(
            "diy-box"
            , "DiyBox.Core"
            , new DateOnly(2022, 4, 17)
            , DIHelper);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        ArgumentNullException.ThrowIfNull(SerilogWrapper);
        ArgumentNullException.ThrowIfNull(CLIFramework);
        Set(
            "diy-box-cli-app"
            , "DiyBox.ConsoleApp"
            , true
            , new DateOnly(2022, 4, 17)
            , DIHelper
            , ConfigWrapper
            , SerilogWrapper
            , CLIFramework
            , diyBoxCore);
        var diyBoxCmdDotNet = Set(
            "diy-box"
            , "DiyBox.CommandDotNet"
            , new DateOnly(2022, 4, 17));
        ArgumentNullException.ThrowIfNull(CommandDotNetHelper);
        ArgumentNullException.ThrowIfNull(CommandDotNetIoCUnity);
        ArgumentNullException.ThrowIfNull(CommandDotNetUnityHelper);
        Set(
            "diy-box-modern-cli-app"
            , "DiyBox.Modern.CliApp"
            , true
            , new DateOnly(2022, 4, 17)
            , DIHelper
            , ConfigWrapper
            , CommandDotNetHelper
            , CommandDotNetIoCUnity
            , CommandDotNetUnityHelper
            , SerilogWrapper
            , diyBoxCore
            , diyBoxCmdDotNet);
    }
}