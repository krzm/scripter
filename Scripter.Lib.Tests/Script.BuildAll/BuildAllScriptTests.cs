using System.Collections.Generic;
using Xunit;

namespace Scripter.Lib.Tests;

public class BuildAllScriptTests 
    : LibTest
{
    private static IProjectList codeData
        = new AllAppsList(
            new SumingProjExtractor()
            , new List<ICodeData> 
            {
                new ScripterData()
                , new AppStarterData()
                , new CommanderData()
                , new DiyBoxData()
                , new GameData()
                , new ModernLogData()
                , new ModernMDILogData()
                , new ModernWizardLogData()
                , new ConsoleLogData()
                , new Inventory.ModernAppData()
                , new Inventory.CliLibAppData()
            });

    [Theory]
    [InlineData(0, $"& \"$PSScriptRoot\\DIHelper.Build.ps1\"")]
    [InlineData(1, $"& \"$PSScriptRoot\\Config.Wrapper.Build.ps1\"")]
    [InlineData(2, $"& \"$PSScriptRoot\\ModelHelper.Build.ps1\"")]
    [InlineData(3, $"& \"$PSScriptRoot\\DataToTable.Build.ps1\"")]
    [InlineData(4, $"& \"$PSScriptRoot\\CommandDotNet.Helper.Build.ps1\"")]
    [InlineData(5, $"& \"$PSScriptRoot\\CLIHelper.Build.ps1\"")]
    [InlineData(6, $"& \"$PSScriptRoot\\CommandDotNet.Unity.Helper.Build.ps1\"")]
    [InlineData(7, $"& \"$PSScriptRoot\\Serilog.Wrapper.Build.ps1\"")]
    [InlineData(8, $"& \"$PSScriptRoot\\Scripter.Build.ps1\"")]
    [InlineData(9, $"& \"$PSScriptRoot\\EFCoreHelper.Build.ps1\"")]
    [InlineData(10, $"& \"$PSScriptRoot\\DotNetExtension.Build.ps1\"")]
    [InlineData(11, $"& \"$PSScriptRoot\\DotNetTool.Build.ps1\"")]
    [InlineData(12, $"& \"$PSScriptRoot\\CLIReader.Build.ps1\"")]
    [InlineData(13, $"& \"$PSScriptRoot\\CRUDCommandHelper.Build.ps1\"")]
    [InlineData(14, $"& \"$PSScriptRoot\\CLIWizardHelper.Build.ps1\"")]
    [InlineData(15, $"& \"$PSScriptRoot\\CLIFramework.Build.ps1\"")]
    [InlineData(16, $"& \"$PSScriptRoot\\AppStarter.Data.Build.ps1\"")]
    [InlineData(17, $"& \"$PSScriptRoot\\AppStarter.Lib.Build.ps1\"")]
    [InlineData(18, $"& \"$PSScriptRoot\\AppStarter.ConsoleApp.Build.ps1\"")]
    [InlineData(19, $"& \"$PSScriptRoot\\Commander.Build.ps1\"")]
    [InlineData(20, $"& \"$PSScriptRoot\\DiyBox.Core.Build.ps1\"")]
    [InlineData(21, $"& \"$PSScriptRoot\\DiyBox.ConsoleApp.Build.ps1\"")]
    [InlineData(22, $"& \"$PSScriptRoot\\GameData.Data.Lib.Build.ps1\"")]
    [InlineData(23, $"& \"$PSScriptRoot\\GameData.Lib.Build.ps1\"")]
    [InlineData(24, $"& \"$PSScriptRoot\\GameData.ConsoleApp.Build.ps1\"")]
    [InlineData(25, $"& \"$PSScriptRoot\\CommandDotNet.IoC.Unity.Build.ps1\"")]
    [InlineData(26, $"& \"$PSScriptRoot\\Log.Data.Build.ps1\"")]
    [InlineData(27, $"& \"$PSScriptRoot\\Log.Table.Build.ps1\"")]
    [InlineData(28, $"& \"$PSScriptRoot\\Log.Modern.Lib.Build.ps1\"")]
    [InlineData(29, $"& \"$PSScriptRoot\\Log.Modern.ConsoleApp.Build.ps1\"")]
    [InlineData(30, "& \"$PSScriptRoot\\CommandDotNet.MDI.Helper.Build.ps1\"")]
    [InlineData(31, "& \"$PSScriptRoot\\Log.Modern.MDI.ConsoleApp.Build.ps1\"")]
    [InlineData(32, "& \"$PSScriptRoot\\Log.Wizard.Lib.Build.ps1\"")]
    [InlineData(33, "& \"$PSScriptRoot\\Log.Modern.Wizard.ConsoleApp.Build.ps1\"")]
    [InlineData(34, $"& \"$PSScriptRoot\\Log.Console.Lib.Build.ps1\"")]
    [InlineData(35, $"& \"$PSScriptRoot\\Log.ConsoleApp.Build.ps1\"")]
    [InlineData(36, $"& \"$PSScriptRoot\\Inventory.Data.Build.ps1\"")]
    [InlineData(37, $"& \"$PSScriptRoot\\Inventory.Table.Build.ps1\"")]
    [InlineData(38, $"& \"$PSScriptRoot\\Inventory.Modern.Lib.Build.ps1\"")]
    [InlineData(39, $"& \"$PSScriptRoot\\Inventory.Modern.ConsoleApp.Build.ps1\"")]
    [InlineData(40, $"& \"$PSScriptRoot\\Inventory.Wizard.Lib.Build.ps1\"")]
    [InlineData(41, $"& \"$PSScriptRoot\\Inventory.Console.Lib.Build.ps1\"")]
    [InlineData(42, $"& \"$PSScriptRoot\\Inventory.ConsoleLib.ConsoleApp.Build.ps1\"")]
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