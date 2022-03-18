namespace Scripter;

public class LibCData 
    : LibBData
{
    protected ProjectDTO? CLIReader;
    protected ProjectDTO? ConfigWrapper;
    protected ProjectDTO? CommandDotNetHelper;
    protected ProjectDTO? CommandDotNetMDIHelper;
    protected ProjectDTO? CommandDotNetUnityHelper;
    
    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(DIHelper);
        CLIReader = Set(
            "cli-reader"
            , "CLIReader"
            , new DateOnly(2022, 03, 16)
            , CLIHelper
            , DIHelper);
        ConfigWrapper = Set(
            "config-wrapper"
            , "Config.Wrapper"
            , new DateOnly(2022, 03, 18)
            , DIHelper);
        CommandDotNetHelper = Set(
            "commanddotnet-helper"
            , "CommandDotNet.Helper"
            , new DateOnly(2022, 03, 18)
            , DIHelper
            , ConfigWrapper);
        CommandDotNetMDIHelper = Set(
            "commanddotnet-helper"
            , "CommandDotNet.MDI.Helper");
        CommandDotNetUnityHelper = Set(
            "commanddotnet-helper"
            , "CommandDotNet.Unity.Helper");
    }
}