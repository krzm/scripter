using Xunit;

namespace Scripter.Lib.Tests;

public class AppStarterTests
    : LibTest
{
    private static ICodeData appData
        = new AppData();

    [Theory]
    [InlineData(0, $"& \"$PSScriptRoot\\ModelHelper.Build.ps1\"")]
    [InlineData(1, $"& \"$PSScriptRoot\\EFCoreHelper.Build.ps1\"")]
    [InlineData(2, $"& \"$PSScriptRoot\\DotNetExtension.Build.ps1\"")]
    [InlineData(3, $"& \"$PSScriptRoot\\CLIHelper.Build.ps1\"")]
    [InlineData(4, $"& \"$PSScriptRoot\\CLIReader.Build.ps1\"")]
    [InlineData(5, $"& \"$PSScriptRoot\\DotNetTool.Build.ps1\"")]
    [InlineData(6, $"& \"$PSScriptRoot\\DIHelper.Build.ps1\"")]
    [InlineData(7, $"& \"$PSScriptRoot\\DataToTable.Build.ps1\"")]
    [InlineData(8, $"& \"$PSScriptRoot\\CommandDotNet.IoC.Unity.Build.ps1\"")]
    [InlineData(9, $"& \"$PSScriptRoot\\CommandDotNet.Helper.Build.ps1\"")]
    [InlineData(10, $"& \"$PSScriptRoot\\CRUDCommandHelper.Build.ps1\"")]
    [InlineData(11, $"& \"$PSScriptRoot\\CLIWizardHelper.Build.ps1\"")]
    [InlineData(12, $"& \"$PSScriptRoot\\CLIFramework.Build.ps1\"")]
    [InlineData(13, $"& \"$PSScriptRoot\\AppStarter.Data.Build.ps1\"")]
    [InlineData(14, $"& \"$PSScriptRoot\\AppStarter.Lib.Build.ps1\"")]
    [InlineData(15, $"& \"$PSScriptRoot\\AppStarter.ConsoleApp.Build.ps1\"")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        IScript script = new AppStarterBuildAll(appData);

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}