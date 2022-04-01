using Xunit;

namespace Scripter.Lib.Tests;

public class ScripterTests 
    : LibTest
{
    private static ICodeData codeData
        = new ScripterData();

    [Theory]
    //IndependantLibData
    [InlineData(0, $"& \"$PSScriptRoot\\DIHelper.Build.ps1\"")]
    //OneRefLibData
    [InlineData(1, $"& \"$PSScriptRoot\\Config.Wrapper.Build.ps1\"")]
    //TwoRefLibData
    [InlineData(2, $"& \"$PSScriptRoot\\ModelHelper.Build.ps1\"")]//dep
    [InlineData(3, $"& \"$PSScriptRoot\\DataToTable.Build.ps1\"")]
    //CommandDotNetLibData
    [InlineData(4, $"& \"$PSScriptRoot\\CommandDotNet.Helper.Build.ps1\"")]
    [InlineData(5, $"& \"$PSScriptRoot\\CLIHelper.Build.ps1\"")]//dep
    [InlineData(6, $"& \"$PSScriptRoot\\CommandDotNet.Unity.Helper.Build.ps1\"")]
    //ManyRefLibData
    [InlineData(7, $"& \"$PSScriptRoot\\Serilog.Wrapper.Build.ps1\"")]
    [InlineData(8, $"& \"$PSScriptRoot\\Scripter.Build.ps1\"")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        IScript script = new ProjBuildAllScript(
            new ProjectExtractor()
            , codeData
            , new ProjBuildAllDTO(
                "Scripter.BuildAll.ps1"
                , "Scripter"
            ));

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}