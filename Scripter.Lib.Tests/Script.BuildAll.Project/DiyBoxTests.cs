using Xunit;

namespace Scripter.Lib.Tests;

public class DiyBoxTests 
    : LibTest
{
    private static ICodeData appData
        = new AppData();

    [Theory]
    [InlineData(0, $"& \"$PSScriptRoot\\ModelHelper.Build.ps1\"")]
    [InlineData(1, $"& \"$PSScriptRoot\\CLIHelper.Build.ps1\"")]
    [InlineData(2, $"& \"$PSScriptRoot\\CLIReader.Build.ps1\"")]
    [InlineData(3, $"& \"$PSScriptRoot\\DIHelper.Build.ps1\"")]
    [InlineData(4, $"& \"$PSScriptRoot\\CommandDotNet.IoC.Unity.Build.ps1\"")]
    [InlineData(5, $"& \"$PSScriptRoot\\CommandDotNet.Helper.Build.ps1\"")]
    [InlineData(6, $"& \"$PSScriptRoot\\EFCoreHelper.Build.ps1\"")]
    [InlineData(7, $"& \"$PSScriptRoot\\DataToTable.Build.ps1\"")]
    [InlineData(8, $"& \"$PSScriptRoot\\CRUDCommandHelper.Build.ps1\"")]
    [InlineData(9, $"& \"$PSScriptRoot\\CLIWizardHelper.Build.ps1\"")]
    [InlineData(10, $"& \"$PSScriptRoot\\CLIFramework.Build.ps1\"")]
    [InlineData(11, $"& \"$PSScriptRoot\\DiyBox.ConsoleApp.Build.ps1\"")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        IScript script = new DiyBoxBuildAll(appData);

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}