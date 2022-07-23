using Scripter.Data.Helper;

namespace Scripter.Data;

public class CommandDotNetLibData 
    : ManyRefLibData
{
    private const string Repo = "commanddotnet-helper";
    protected ProjectDTO? CommandDotNetHelper;
    protected ProjectDTO? CommandDotNetMDIHelper;
    protected ProjectDTO? CommandDotNetIoCUnity;
    protected ProjectDTO? CommandDotNetUnityHelper;
    
    protected override void SetAllData()
    {
        base.SetAllData();
        var lastUpd = new DateOnly(2022, 6, 26);
        ArgumentNullException.ThrowIfNull(DIHelper);
        ArgumentNullException.ThrowIfNull(ConfigWrapper);
        CommandDotNetHelper = SetProjectDepsAndTests(
            Repo
            , "CommandDotNet.Helper"
            , lastUpd
            , SetTests("CommandDotNet.Helpers.Tests")
            , DIHelper
            , ConfigWrapper);
        CommandDotNetMDIHelper = Set(
            Repo
            , "CommandDotNet.MDI.Helper"
            , lastUpd
            , DIHelper
            , ConfigWrapper);
        CommandDotNetIoCUnity = Set(
            Repo
            , project: "CommandDotNet.IoC.Unity"
            , lastUpd);
        ArgumentNullException.ThrowIfNull(CLIHelper);
        CommandDotNetUnityHelper = Set(
            Repo
            , "CommandDotNet.Unity.Helper"
            , lastUpd
            , DIHelper
            , CLIHelper
            , ConfigWrapper
            );
    }
}