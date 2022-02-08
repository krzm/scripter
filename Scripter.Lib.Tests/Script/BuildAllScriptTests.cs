using Xunit;

namespace Scripter.Lib.Tests;

public class BuildAllScriptTests : ScriptTestBase
{
    private static ProjectList projectList = new ProjectList();

    [Theory]
    [InlineData(0, $"& \"$PSScriptRoot\\CLIHelper.Build.ps1\"")]
    [InlineData(1, $"& \"$PSScriptRoot\\CLIReader.Build.ps1\"")]
    [InlineData(2, $"& \"$PSScriptRoot\\CommandDotNet.IoC.Unity.Build.ps1\"")]
    [InlineData(3, $"& \"$PSScriptRoot\\DIHelper.Build.ps1\"")]
    [InlineData(4, $"& \"$PSScriptRoot\\CommandDotNet.Helper.Build.ps1\"")]
    [InlineData(5, $"& \"$PSScriptRoot\\ModelHelper.Build.ps1\"")]
    [InlineData(6, $"& \"$PSScriptRoot\\DataToTable.Build.ps1\"")]
    [InlineData(7, $"& \"$PSScriptRoot\\Scripter.Build.ps1\"")]
    [InlineData(8, $"& \"$PSScriptRoot\\EFCoreHelper.Build.ps1\"")]
    [InlineData(9, $"& \"$PSScriptRoot\\Log.Data.Build.ps1\"")]
    [InlineData(10, $"& \"$PSScriptRoot\\CRUDCommandHelper.Build.ps1\"")]
    [InlineData(11, $"& \"$PSScriptRoot\\CLIWizardHelper.Build.ps1\"")]
    [InlineData(12, $"& \"$PSScriptRoot\\CLIFramework.Build.ps1\"")]
    [InlineData(13, $"& \"$PSScriptRoot\\CLIFramework.TestApp.Build.ps1\"")]
    [InlineData(14, $"& \"$PSScriptRoot\\Log.Wizard.Lib.Build.ps1\"")]
    [InlineData(15, $"& \"$PSScriptRoot\\DotNetExtension.Build.ps1\"")]
    [InlineData(16, $"& \"$PSScriptRoot\\Log.Modern.Lib.Build.ps1\"")]
    [InlineData(17, $"& \"$PSScriptRoot\\Log.Console.Lib.Build.ps1\"")]
    [InlineData(18, $"& \"$PSScriptRoot\\Log.Modern.ConsoleApp.Build.ps1\"")]
    [InlineData(19, $"& \"$PSScriptRoot\\Log.ConsoleApp.Build.ps1\"")]
    [InlineData(20, $"& \"$PSScriptRoot\\Log.Modern.MDI.ConsoleApp.Build.ps1\"")]
    [InlineData(21, $"& \"$PSScriptRoot\\Log.Modern.Wizard.ConsoleApp.Build.ps1\"")]
    [InlineData(22, $"& \"$PSScriptRoot\\AppStarter.ConsoleApp.Build.ps1\"")]
    [InlineData(23, $"& \"$PSScriptRoot\\DotNetTool.Build.ps1\"")]
    [InlineData(24, $"& \"$PSScriptRoot\\Inventory.Data.Build.ps1\"")]
    [InlineData(25, $"& \"$PSScriptRoot\\Inventory.Wizard.Lib.Build.ps1\"")]
    [InlineData(26, $"& \"$PSScriptRoot\\Inventory.Console.Lib.Build.ps1\"")]
    [InlineData(27, $"& \"$PSScriptRoot\\Inventory.Modern.Lib.Build.ps1\"")]
    [InlineData(28, $"& \"$PSScriptRoot\\Inventory.ConsoleLib.ConsoleApp.Build.ps1\"")]
    [InlineData(29, $"& \"$PSScriptRoot\\Inventory.Modern.ConsoleApp.Build.ps1\"")]
    [InlineData(30, $"& \"$PSScriptRoot\\Diybox.ConsoleApp.Build.ps1\"")]
    [InlineData(31, $"& \"$PSScriptRoot\\GameData.ConsoleApp.Build.ps1\"")]
    [InlineData(32, $"& \"$PSScriptRoot\\Commander.Build.ps1\"")]
    [InlineData(33, $"& \"$PSScriptRoot\\TRMApi.Build.ps1\"")]
    [InlineData(34, $"& \"$PSScriptRoot\\Portal.Build.ps1\"")]
    [InlineData(35, $"& \"$PSScriptRoot\\WpfHelper.Build.ps1\"")]
    [InlineData(36, $"& \"$PSScriptRoot\\Pattern.Build.ps1\"")]
    [InlineData(37, $"& \"$PSScriptRoot\\Net.Examples.Build.ps1\"")]
    [InlineData(38, $"& \"$PSScriptRoot\\UnityContainer.Tests.Build.ps1\"")]
    [InlineData(39, $"& \"$PSScriptRoot\\CommandDotNet.Examples.App.Build.ps1\"")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        IScript script = new BuildAllScript(projectList);

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}