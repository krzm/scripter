namespace Scripter;

public class CommandDotNetLibData 
    : OneRefLibData
{
    protected ProjectDTO? CommandDotNetHelper;
    protected ProjectDTO? CommandDotNetMDIHelper;
    protected ProjectDTO? CommandDotNetIoCUnity;
    protected ProjectDTO? CommandDotNetUnityHelper;
    
    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        CommandDotNetHelper = Set(
            "commanddotnet-helper"
            , "CommandDotNet.Helper"
            , new DateOnly(2022, 3, 18)
            , DIHelper
            , ConfigWrapper);
        CommandDotNetMDIHelper = Set(
            "commanddotnet-helper"
            , "CommandDotNet.MDI.Helper"
            , new DateOnly(2022, 4, 1)
            , DIHelper
            , ConfigWrapper);
        CommandDotNetIoCUnity = Set(
            "commanddotnet-helper/"
            , "CommandDotNet.IoC.Unity");
        CommandDotNetUnityHelper = Set(
            "commanddotnet-helper"
            , "CommandDotNet.Unity.Helper"
            , new DateOnly(2022, 4, 1)
            , DIHelper
            , CLIHelper
            , ConfigWrapper
            );
    }
}