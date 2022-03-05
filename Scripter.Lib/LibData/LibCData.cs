namespace Scripter;

public class LibCData 
    : LibBData
{
    protected ProjectDTO? DIHelper;
    protected ProjectDTO? CommandDotNetHelper;
    protected ProjectDTO? CommandDotNetMDIHelper;
    protected ProjectDTO? CommandDotNetUnityHelper;
    
    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(CLIHelper);
        ArgumentNullException.ThrowIfNull(CLIReader);
        DIHelper = Set(
            "di-helper"
            , "DIHelper"
            , CLIHelper
            , CLIReader);
        CommandDotNetHelper = Set(
            "commanddotnet-helper"
            , "CommandDotNet.Helper"
            , DIHelper);
        CommandDotNetMDIHelper = Set(
            "commanddotnet-helper"
            , "CommandDotNet.MDI.Helper");
        CommandDotNetUnityHelper = Set(
            "commanddotnet-helper"
            , "CommandDotNet.Unity.Helper");
    }
}