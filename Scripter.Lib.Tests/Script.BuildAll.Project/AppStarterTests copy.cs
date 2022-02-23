using Xunit;

namespace Scripter.Lib.Tests;

public class GameDataTests
    : ScriptTestBase
{
    private static ICodeData appData
        = new AppData();

    [Theory]
    [InlineData(0, $"& \"$PSScriptRoot\\ModelHelper.Build.ps1\"")]
    [InlineData(1, $"& \"$PSScriptRoot\\EFCoreHelper.Build.ps1\"")]
    [InlineData(2, $"& \"$PSScriptRoot\\DotNetExtension.Build.ps1\"")]
    [InlineData(3, $"& \"$PSScriptRoot\\CLIHelper.Build.ps1\"")]
    [InlineData(4, $"& \"$PSScriptRoot\\DataToTable.Build.ps1\"")]
    [InlineData(5, $"& \"$PSScriptRoot\\CLIReader.Build.ps1\"")]
    [InlineData(6, $"& \"$PSScriptRoot\\CRUDCommandHelper.Build.ps1\"")]
    [InlineData(7, $"& \"$PSScriptRoot\\DIHelper.Build.ps1\"")]
    [InlineData(8, $"& \"$PSScriptRoot\\CommandDotNet.IoC.Unity.Build.ps1\"")]
    [InlineData(9, $"& \"$PSScriptRoot\\CommandDotNet.Helper.Build.ps1\"")]
    [InlineData(10, $"& \"$PSScriptRoot\\CLIWizardHelper.Build.ps1\"")]
    [InlineData(11, $"& \"$PSScriptRoot\\CLIFramework.Build.ps1\"")]
    [InlineData(12, $"& \"$PSScriptRoot\\GameData.Data.Lib.Build.ps1\"")]
    [InlineData(13, $"& \"$PSScriptRoot\\GameData.Lib.Build.ps1\"")]
    [InlineData(14, $"& \"$PSScriptRoot\\GameData.ConsoleApp.Build.ps1\"")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        IScript script = new GameDataBuildAll(appData);

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}