using Xunit;

namespace Scripter.Lib.Tests.BuildAll.Log;

public class ModernLogTests 
    : LibTest
{
    private static ICodeData codeData
        = new LogData();

    [Theory]
    [InlineData(0, $"& \"$PSScriptRoot\\ModelHelper.Build.ps1\"")]
    [InlineData(1, $"& \"$PSScriptRoot\\EFCoreHelper.Build.ps1\"")]
    [InlineData(2, $"& \"$PSScriptRoot\\DataToTable.Build.ps1\"")]
    [InlineData(3, $"& \"$PSScriptRoot\\CLIHelper.Build.ps1\"")]
    [InlineData(4, $"& \"$PSScriptRoot\\CLIReader.Build.ps1\"")]
    [InlineData(5, $"& \"$PSScriptRoot\\DIHelper.Build.ps1\"")]
    [InlineData(6, $"& \"$PSScriptRoot\\CommandDotNet.IoC.Unity.Build.ps1\"")]
    [InlineData(7, $"& \"$PSScriptRoot\\CommandDotNet.Helper.Build.ps1\"")]
    [InlineData(8, $"& \"$PSScriptRoot\\CRUDCommandHelper.Build.ps1\"")]
    [InlineData(9, $"& \"$PSScriptRoot\\Log.Data.Build.ps1\"")]
    [InlineData(10, $"& \"$PSScriptRoot\\DotNetExtension.Build.ps1\"")]
    [InlineData(11, $"& \"$PSScriptRoot\\Log.Modern.Lib.Build.ps1\"")]
    [InlineData(12, $"& \"$PSScriptRoot\\Log.Modern.ConsoleApp.Build.ps1\"")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        IScript script = new ProjBuildAllScript(
            new ProjectExtractor()
            , codeData
            , new ProjBuildAllDTO(
                "ModernLog.BuildAll.ps1"
                , "Log.Modern.ConsoleApp"
            ));

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}