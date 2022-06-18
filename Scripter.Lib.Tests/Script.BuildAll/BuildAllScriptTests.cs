using System.Collections.Generic;
using Scripter.Data;
using Scripter.Data.Helper;
using Xunit;

namespace Scripter.Lib.Tests;

public class BuildAllScriptTests 
    : ScriptTest
{
    private static IProjectList codeData
        = new AllAppsList(
            new SumingProjExtractor()
            , new List<ICodeData> 
            {
                new ScripterData()
                , new CliAppTemplateData()
                , new AppStarterData()
                , new CommanderData()
                , new MicroservicesData()
                , new DiyBoxData()
                , new GameData()
                , new ModernLogData()
                , new ModernMDILogData()
                , new ModernWizardLogData()
                , new ConsoleLogData()
                , new ModernInventoryAppData()
                , new MyCliLibInventoryAppData()
            });

    [Theory]
    [InlineData(0, $"& \"$PSScriptRoot\\DIHelper.Build.ps1\"")]
    [InlineData(1, $"& \"$PSScriptRoot\\Config.Wrapper.Build.ps1\"")]
    [InlineData(2, $"& \"$PSScriptRoot\\ModelHelper.Build.ps1\"")]
    [InlineData(3, $"& \"$PSScriptRoot\\DataToTable.Build.ps1\"")]
    [InlineData(4, $"& \"$PSScriptRoot\\CLIHelper.Build.ps1\"")]
    [InlineData(5, $"& \"$PSScriptRoot\\CommandDotNet.Helper.Build.ps1\"")]
    [InlineData(6, $"& \"$PSScriptRoot\\CommandDotNet.Unity.Helper.Build.ps1\"")]
    [InlineData(7, $"& \"$PSScriptRoot\\Serilog.Wrapper.Build.ps1\"")]
    [InlineData(8, $"& \"$PSScriptRoot\\Scripter.Build.ps1\"")]
    [InlineData(9, $"& \"$PSScriptRoot\\CLI.App.Template.Build.ps1\"")]
    [InlineData(10, $"& \"$PSScriptRoot\\EFCoreHelper.Build.ps1\"")]
    [InlineData(11, $"& \"$PSScriptRoot\\DotNetExtension.Build.ps1\"")]
    [InlineData(12, $"& \"$PSScriptRoot\\DotNetTool.Build.ps1\"")]
    [InlineData(13, $"& \"$PSScriptRoot\\CLIReader.Build.ps1\"")]
    [InlineData(14, $"& \"$PSScriptRoot\\CRUDCommandHelper.Build.ps1\"")]
    [InlineData(15, $"& \"$PSScriptRoot\\CLIWizardHelper.Build.ps1\"")]
    [InlineData(16, $"& \"$PSScriptRoot\\CLIFramework.Build.ps1\"")]
    [InlineData(17, $"& \"$PSScriptRoot\\AppStarter.Data.Build.ps1\"")]
    [InlineData(18, $"& \"$PSScriptRoot\\AppStarter.Lib.Build.ps1\"")]
    [InlineData(19, $"& \"$PSScriptRoot\\AppStarter.ConsoleApp.Build.ps1\"")]
    [InlineData(20, $"& \"$PSScriptRoot\\Commander.Build.ps1\"")]
    [InlineData(21, $"& \"$PSScriptRoot\\CommandsService.Build.ps1\"")]
    [InlineData(22, $"& \"$PSScriptRoot\\PlatformService.Build.ps1\"")]
    [InlineData(23, $"& \"$PSScriptRoot\\DiyBox.Core.Build.ps1\"")]
    [InlineData(24, $"& \"$PSScriptRoot\\DiyBox.ConsoleApp.Build.ps1\"")]
    [InlineData(25, $"& \"$PSScriptRoot\\CommandDotNet.IoC.Unity.Build.ps1\"")]
    [InlineData(26, $"& \"$PSScriptRoot\\DiyBox.CommandDotNet.Build.ps1\"")]
    [InlineData(27, $"& \"$PSScriptRoot\\DiyBox.Modern.CliApp.Build.ps1\"")]
    [InlineData(28, $"& \"$PSScriptRoot\\GameData.Data.Lib.Build.ps1\"")]
    [InlineData(29, $"& \"$PSScriptRoot\\GameData.Lib.Build.ps1\"")]
    [InlineData(30, $"& \"$PSScriptRoot\\GameData.ConsoleApp.Build.ps1\"")]
    [InlineData(31, $"& \"$PSScriptRoot\\Log.Data.Build.ps1\"")]
    [InlineData(32, $"& \"$PSScriptRoot\\Log.Table.Build.ps1\"")]
    [InlineData(33, $"& \"$PSScriptRoot\\Log.Modern.Lib.Build.ps1\"")]
    [InlineData(34, $"& \"$PSScriptRoot\\Log.Modern.ConsoleApp.Build.ps1\"")]
    [InlineData(35, "& \"$PSScriptRoot\\CommandDotNet.MDI.Helper.Build.ps1\"")]
    [InlineData(36, "& \"$PSScriptRoot\\Log.Modern.MDI.ConsoleApp.Build.ps1\"")]
    [InlineData(37, "& \"$PSScriptRoot\\Log.Wizard.Lib.Build.ps1\"")]
    [InlineData(38, "& \"$PSScriptRoot\\Log.Modern.Wizard.ConsoleApp.Build.ps1\"")]
    [InlineData(39, $"& \"$PSScriptRoot\\Log.Console.Lib.Build.ps1\"")]
    [InlineData(40, $"& \"$PSScriptRoot\\Log.ConsoleApp.Build.ps1\"")]
    [InlineData(41, $"& \"$PSScriptRoot\\Inventory.Data.Build.ps1\"")]
    [InlineData(42, $"& \"$PSScriptRoot\\Inventory.Table.Build.ps1\"")]
    [InlineData(43, $"& \"$PSScriptRoot\\Inventory.Modern.Lib.Build.ps1\"")]
    [InlineData(44, $"& \"$PSScriptRoot\\Inventory.Modern.ConsoleApp.Build.ps1\"")]
    [InlineData(45, $"& \"$PSScriptRoot\\Inventory.Wizard.Lib.Build.ps1\"")]
    [InlineData(46, $"& \"$PSScriptRoot\\Inventory.Console.Lib.Build.ps1\"")]
    [InlineData(47, $"& \"$PSScriptRoot\\Inventory.ConsoleLib.ConsoleApp.Build.ps1\"")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        IScript script = new BuildAllScript(
            codeData
            , new BuildAllDTO("BuildAll.ps1"));
   
        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}