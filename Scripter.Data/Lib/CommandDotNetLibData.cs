using Scripter.Data.Helper;

namespace Scripter.Data;

public class CommandDotNetLibData 
    : OneRefLibData
{
    private const string Repo = "commanddotnet-helper";
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
            Repo
            , "CommandDotNet.Helper"
            , new DateOnly(2022, 3, 18)
            , DIHelper
            , ConfigWrapper);
        CommandDotNetMDIHelper = Set(
            Repo
            , "CommandDotNet.MDI.Helper"
            , new DateOnly(2022, 4, 1)
            , DIHelper
            , ConfigWrapper);
        CommandDotNetIoCUnity = Set(
            repo: Repo
            , project: "CommandDotNet.IoC.Unity"
            , new DateOnly(2022, 4, 1));
        CommandDotNetUnityHelper = Set(
            Repo
            , "CommandDotNet.Unity.Helper"
            , new DateOnly(2022, 4, 1)
            , DIHelper
            , CLIHelper
            , ConfigWrapper
            );
    }
}