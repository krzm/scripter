using Xunit;

namespace Scripter.Lib.Tests;

public class ModernInventoryTests 
    : ScriptTestBase
{
    private static ICodeData appData
        = new InventoryData();

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
    [InlineData(9, $"& \"$PSScriptRoot\\Inventory.Data.Build.ps1\"")]
    [InlineData(10, $"& \"$PSScriptRoot\\DotNetExtension.Build.ps1\"")]
    [InlineData(11, $"& \"$PSScriptRoot\\Inventory.Modern.Lib.Build.ps1\"")]
    [InlineData(12, $"& \"$PSScriptRoot\\Inventory.Modern.ConsoleApp.Build.ps1\"")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        IScript script = new ModernInventoryBuildAll(appData);

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}