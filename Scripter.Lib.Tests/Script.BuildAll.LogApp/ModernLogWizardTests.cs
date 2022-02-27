using Xunit;

namespace Scripter.Lib.Tests.BuildAll.Log;

public class ModernLogWizardTests 
    : LibTest
{
    private static ICodeData appData
        = new LogData();

    [Theory]
    [InlineData(0, $"& \"$PSScriptRoot\\ModelHelper.Build.ps1\"")]
    [InlineData(1, $"& \"$PSScriptRoot\\EFCoreHelper.Build.ps1\"")]
    [InlineData(2, $"& \"$PSScriptRoot\\DotNetExtension.Build.ps1\"")]
    [InlineData(3, $"& \"$PSScriptRoot\\CLIHelper.Build.ps1\"")]
    [InlineData(4, $"& \"$PSScriptRoot\\CLIReader.Build.ps1\"")]
    [InlineData(5, $"& \"$PSScriptRoot\\DataToTable.Build.ps1\"")]
    [InlineData(6, $"& \"$PSScriptRoot\\DIHelper.Build.ps1\"")]
    [InlineData(7, $"& \"$PSScriptRoot\\CommandDotNet.IoC.Unity.Build.ps1\"")]
    [InlineData(8, $"& \"$PSScriptRoot\\CommandDotNet.Helper.Build.ps1\"")]
    [InlineData(9, $"& \"$PSScriptRoot\\CLIWizardHelper.Build.ps1\"")]
    [InlineData(10, $"& \"$PSScriptRoot\\CRUDCommandHelper.Build.ps1\"")]
    [InlineData(11, $"& \"$PSScriptRoot\\Log.Data.Build.ps1\"")]
    [InlineData(12, $"& \"$PSScriptRoot\\Log.Wizard.Lib.Build.ps1\"")]
    [InlineData(13, $"& \"$PSScriptRoot\\Log.Modern.Lib.Build.ps1\"")]
    [InlineData(14, $"& \"$PSScriptRoot\\Log.Modern.Wizard.ConsoleApp.Build.ps1\"")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        IScript script = new ModernLogWizardBuildAll(appData);

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}