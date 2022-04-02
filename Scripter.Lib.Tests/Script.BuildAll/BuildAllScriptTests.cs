using System.Collections.Generic;
using Xunit;

namespace Scripter.Lib.Tests;

public class BuildAllScriptTests 
    : LibTest
{
    private static IProjectList codeData
        = new AllProjList(
            new ResetingProjExtractor()
            , new List<ICodeData> 
            {
                new ManyRefLibData()
                //, new ScripterData()
                //, new ModernLogData(),
                //new ModernInventoryData()
            });

    [Theory]
    //IndependantLibData
    [InlineData(0, $"& \"$PSScriptRoot\\EFCoreHelper.Build.ps1\"")]
    [InlineData(1, $"& \"$PSScriptRoot\\DIHelper.Build.ps1\"")]
    [InlineData(2, $"& \"$PSScriptRoot\\DotNetExtension.Build.ps1\"")]
    [InlineData(3, $"& \"$PSScriptRoot\\DotNetTool.Build.ps1\"")]
    //OneRefLibData
    [InlineData(4, $"& \"$PSScriptRoot\\CLIHelper.Build.ps1\"")]
    [InlineData(5, $"& \"$PSScriptRoot\\Config.Wrapper.Build.ps1\"")]
    [InlineData(6, $"& \"$PSScriptRoot\\ModelHelper.Build.ps1\"")]
    //CommandDotNetLibData
    [InlineData(7, $"& \"$PSScriptRoot\\CommandDotNet.Helper.Build.ps1\"")]
    [InlineData(8, $"& \"$PSScriptRoot\\CommandDotNet.MDI.Helper.Build.ps1\"")]
    [InlineData(9, $"& \"$PSScriptRoot\\CommandDotNet.IoC.Unity.Build.ps1\"")]
    [InlineData(10, $"& \"$PSScriptRoot\\CommandDotNet.Unity.Helper.Build.ps1\"")]
    //TwoRefLibData
    [InlineData(11, $"& \"$PSScriptRoot\\CLIReader.Build.ps1\"")]
    [InlineData(12, $"& \"$PSScriptRoot\\DataToTable.Build.ps1\"")]
    //ManyRefLibData
    [InlineData(13, $"& \"$PSScriptRoot\\Serilog.Wrapper.Build.ps1\"")]
    [InlineData(14, $"& \"$PSScriptRoot\\CRUDCommandHelper.Build.ps1\"")]
    [InlineData(15, $"& \"$PSScriptRoot\\CLIWizardHelper.Build.ps1\"")]
    [InlineData(16, $"& \"$PSScriptRoot\\CLIFramework.Build.ps1\"")]
    //
    //[InlineData(13, $"& \"$PSScriptRoot\\Scripter.Build.ps1\"")]
    // [InlineData(14, $"& \"$PSScriptRoot\\AppStarter.Data.Build.ps1\"")]
    // [InlineData(15, $"& \"$PSScriptRoot\\AppStarter.Lib.Build.ps1\"")]
    // [InlineData(16, $"& \"$PSScriptRoot\\AppStarter.ConsoleApp.Build.ps1\"")]
    // [InlineData(17, $"& \"$PSScriptRoot\\DiyBox.Core.Build.ps1\"")]
    // [InlineData(18, $"& \"$PSScriptRoot\\DiyBox.ConsoleApp.Build.ps1\"")]
    // [InlineData(19, $"& \"$PSScriptRoot\\GameData.Data.Lib.Build.ps1\"")]
    // [InlineData(20, $"& \"$PSScriptRoot\\GameData.Lib.Build.ps1\"")]
    // [InlineData(21, $"& \"$PSScriptRoot\\GameData.ConsoleApp.Build.ps1\"")]
    // //
    // [InlineData(22, $"& \"$PSScriptRoot\\Log.Data.Build.ps1\"")]
    // [InlineData(23, $"& \"$PSScriptRoot\\Log.Modern.Lib.Build.ps1\"")]
    // [InlineData(24, $"& \"$PSScriptRoot\\Log.Modern.ConsoleApp.Build.ps1\"")]
    // [InlineData(25, $"& \"$PSScriptRoot\\Log.Modern.MDI.ConsoleApp.Build.ps1\"")]
    // [InlineData(26, $"& \"$PSScriptRoot\\Log.Console.Lib.Build.ps1\"")]
    // [InlineData(27, $"& \"$PSScriptRoot\\Log.Wizard.Lib.Build.ps1\"")]
    // [InlineData(28, $"& \"$PSScriptRoot\\Log.ConsoleApp.Build.ps1\"")]
    // [InlineData(29, $"& \"$PSScriptRoot\\Log.Modern.Wizard.ConsoleApp.Build.ps1\"")]
    // //
    // [InlineData(30, $"& \"$PSScriptRoot\\Inventory.Data.Build.ps1\"")]
    // [InlineData(31, $"& \"$PSScriptRoot\\Inventory.Modern.Lib.Build.ps1\"")]
    // [InlineData(32, $"& \"$PSScriptRoot\\Inventory.Modern.ConsoleApp.Build.ps1\"")]
    // [InlineData(33, $"& \"$PSScriptRoot\\Inventory.Console.Lib.Build.ps1\"")]
    // [InlineData(34, $"& \"$PSScriptRoot\\Inventory.Wizard.Lib.Build.ps1\"")]
    // [InlineData(35, $"& \"$PSScriptRoot\\Inventory.ConsoleLib.ConsoleApp.Build.ps1\"")]
    // [InlineData(36, $"& \"$PSScriptRoot\\Commander.Build.ps1\"")]
    // [InlineData(37, $"& \"$PSScriptRoot\\TRMApi.Build.ps1\"")]
    // [InlineData(38, $"& \"$PSScriptRoot\\Portal.Build.ps1\"")]
    // [InlineData(39, $"& \"$PSScriptRoot\\WpfHelper.Build.ps1\"")]
    // [InlineData(40, $"& \"$PSScriptRoot\\Pattern.Build.ps1\"")]
    // [InlineData(41, $"& \"$PSScriptRoot\\Net.Examples.Build.ps1\"")]
    // [InlineData(42, $"& \"$PSScriptRoot\\UnityContainer.Tests.Build.ps1\"")]
    // [InlineData(43, $"& \"$PSScriptRoot\\CommandDotNet.Examples.App.Build.ps1\"")]
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