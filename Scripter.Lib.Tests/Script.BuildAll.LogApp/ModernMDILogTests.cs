using Xunit;

namespace Scripter.Lib.Tests.BuildAll.Log;

public class ModernMDILogTests 
    : LibTest
{
    private static ICodeData appData
        = new LogData();

    [Theory]
    [InlineData(0, $"& \"$PSScriptRoot\\ModelHelper.Build.ps1\"")]
    [InlineData(1, $"& \"$PSScriptRoot\\EFCoreHelper.Build.ps1\"")]
    [InlineData(2, $"& \"$PSScriptRoot\\DotNetExtension.Build.ps1\"")]
    [InlineData(3, $"& \"$PSScriptRoot\\CLIHelper.Build.ps1\"")]
    [InlineData(4, $"& \"$PSScriptRoot\\DataToTable.Build.ps1\"")]
    [InlineData(5, $"& \"$PSScriptRoot\\CLIReader.Build.ps1\"")]
    [InlineData(6, $"& \"$PSScriptRoot\\DIHelper.Build.ps1\"")]
    [InlineData(7, $"& \"$PSScriptRoot\\CommandDotNet.IoC.Unity.Build.ps1\"")]
    [InlineData(8, $"& \"$PSScriptRoot\\CommandDotNet.Helper.Build.ps1\"")]
    [InlineData(9, $"& \"$PSScriptRoot\\CRUDCommandHelper.Build.ps1\"")]
    [InlineData(10, $"& \"$PSScriptRoot\\Log.Data.Build.ps1\"")]
    [InlineData(11, $"& \"$PSScriptRoot\\Log.Modern.Lib.Build.ps1\"")]
    [InlineData(12, $"& \"$PSScriptRoot\\Log.Modern.MDI.ConsoleApp.Build.ps1\"")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        IScript script = new ModernMDILogBuildAll(appData);

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}