using Xunit;

namespace Scripter.Lib.Tests;

public class BuildAllScriptTests 
    : ScriptTest
        , IClassFixture<AllAppsListFixture>
{
    private readonly AllAppsListFixture fixture;

    public BuildAllScriptTests(AllAppsListFixture fixture)
    {
        this.fixture = fixture;
    }

    [Theory]
    [InlineData(0, $"& \"$PSScriptRoot\\DIHelper.Build.ps1\"")]
    [InlineData(1, $"& \"$PSScriptRoot\\Config.Wrapper.Build.ps1\"")]
    [InlineData(2, $"& \"$PSScriptRoot\\ModelHelper.Build.ps1\"")]
    [InlineData(3, $"& \"$PSScriptRoot\\DataToTable.Build.ps1\"")]
    [InlineData(4, $"& \"$PSScriptRoot\\CLIHelper.Build.ps1\"")]
    [InlineData(5, $"& \"$PSScriptRoot\\CommandDotNet.Unity.Helper.Build.ps1\"")]
    [InlineData(6, $"& \"$PSScriptRoot\\CommandDotNet.Helper.Build.ps1\"")]
    [InlineData(7, $"& \"$PSScriptRoot\\Serilog.Wrapper.Build.ps1\"")]
    [InlineData(8, $"& \"$PSScriptRoot\\Scripter.Build.ps1\"")]
    [InlineData(9, $"& \"$PSScriptRoot\\CLI.App.Template.Build.ps1\"")]
    [InlineData(10, $"& \"$PSScriptRoot\\CLIReader.Build.ps1\"")]
    [InlineData(11, $"& \"$PSScriptRoot\\CLIFramework.TestApp.Build.ps1\"")]
    [InlineData(12, $"& \"$PSScriptRoot\\Config.Wrapper.CLI.TestApp.Build.ps1\"")]
    [InlineData(13, $"& \"$PSScriptRoot\\Serilog.Wrapper.CLI.TestApp.Build.ps1\"")]
    [InlineData(14, $"& \"$PSScriptRoot\\CommandDotNet.Examples.App.Build.ps1\"")]
    [InlineData(15, $"& \"$PSScriptRoot\\EFCore.Helper.Build.ps1\"")]
    [InlineData(16, $"& \"$PSScriptRoot\\DotNetExtension.Build.ps1\"")]
    [InlineData(17, $"& \"$PSScriptRoot\\DotNetTool.Build.ps1\"")]
    [InlineData(18, $"& \"$PSScriptRoot\\CRUDCommandHelper.Build.ps1\"")]
    [InlineData(19, $"& \"$PSScriptRoot\\CLIWizardHelper.Build.ps1\"")]
    [InlineData(20, $"& \"$PSScriptRoot\\CLIFramework.Build.ps1\"")]
    [InlineData(21, $"& \"$PSScriptRoot\\AppStarter.Data.Build.ps1\"")]
    [InlineData(22, $"& \"$PSScriptRoot\\AppStarter.Lib.Build.ps1\"")]
    [InlineData(23, $"& \"$PSScriptRoot\\AppStarter.ConsoleApp.Build.ps1\"")]
    [InlineData(24, $"& \"$PSScriptRoot\\Commander.Build.ps1\"")]
    [InlineData(25, $"& \"$PSScriptRoot\\CommandsService.Build.ps1\"")]
    [InlineData(26, $"& \"$PSScriptRoot\\PlatformService.Build.ps1\"")]
    [InlineData(27, $"& \"$PSScriptRoot\\DiyBox.Core.Build.ps1\"")]
    [InlineData(28, $"& \"$PSScriptRoot\\DiyBox.ConsoleApp.Build.ps1\"")]
    [InlineData(29, $"& \"$PSScriptRoot\\CommandDotNet.IoC.Unity.Build.ps1\"")]
    [InlineData(30, $"& \"$PSScriptRoot\\DiyBox.CommandDotNet.Build.ps1\"")]
    [InlineData(31, $"& \"$PSScriptRoot\\DiyBox.Modern.CliApp.Build.ps1\"")]
    [InlineData(32, $"& \"$PSScriptRoot\\GameData.Data.Lib.Build.ps1\"")]
    [InlineData(33, $"& \"$PSScriptRoot\\GameData.Lib.Build.ps1\"")]
    [InlineData(34, $"& \"$PSScriptRoot\\GameData.ConsoleApp.Build.ps1\"")]
    [InlineData(35, $"& \"$PSScriptRoot\\Log.Data.Build.ps1\"")]
    [InlineData(36, $"& \"$PSScriptRoot\\Log.Table.Build.ps1\"")]
    [InlineData(37, $"& \"$PSScriptRoot\\Log.Modern.Lib.Build.ps1\"")]
    [InlineData(38, $"& \"$PSScriptRoot\\Log.Modern.ConsoleApp.Build.ps1\"")]
    [InlineData(39, "& \"$PSScriptRoot\\CommandDotNet.MDI.Helper.Build.ps1\"")]
    [InlineData(40, "& \"$PSScriptRoot\\Log.Modern.MDI.ConsoleApp.Build.ps1\"")]
    [InlineData(41, "& \"$PSScriptRoot\\Log.Wizard.Lib.Build.ps1\"")]
    [InlineData(42, "& \"$PSScriptRoot\\Log.Modern.Wizard.ConsoleApp.Build.ps1\"")]
    [InlineData(43, $"& \"$PSScriptRoot\\Log.Console.Lib.Build.ps1\"")]
    [InlineData(44, $"& \"$PSScriptRoot\\Log.ConsoleApp.Build.ps1\"")]
    [InlineData(45, $"& \"$PSScriptRoot\\Inventory.Data.Build.ps1\"")]
    [InlineData(46, $"& \"$PSScriptRoot\\Inventory.Table.Build.ps1\"")]
    [InlineData(47, $"& \"$PSScriptRoot\\Inventory.Modern.Lib.Build.ps1\"")]
    [InlineData(48, $"& \"$PSScriptRoot\\Inventory.Modern.ConsoleApp.Build.ps1\"")]
    [InlineData(49, $"& \"$PSScriptRoot\\Inventory.Wizard.Lib.Build.ps1\"")]
    [InlineData(50, $"& \"$PSScriptRoot\\Inventory.Console.Lib.Build.ps1\"")]
    [InlineData(51, $"& \"$PSScriptRoot\\Inventory.ConsoleLib.ConsoleApp.Build.ps1\"")]
    [InlineData(52, $"& \"$PSScriptRoot\\Vector.Lib.Build.ps1\"")]
    [InlineData(53, $"& \"$PSScriptRoot\\Sim.Core.Build.ps1\"")]
    [InlineData(54, $"& \"$PSScriptRoot\\Shape.Model.Build.ps1\"")]
    [InlineData(55, $"& \"$PSScriptRoot\\Canvas.App.Build.ps1\"")]
    [InlineData(56, $"& \"$PSScriptRoot\\Canvas.Build.ps1\"")]
    [InlineData(57, $"& \"$PSScriptRoot\\Pool.App.Build.ps1\"")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        IScript script = new BuildAllScript(
            fixture.CodeData
            , new BuildAllDTO("BuildAll.ps1"));
   
        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}