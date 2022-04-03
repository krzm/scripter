using System.Collections.Generic;
using Xunit;

namespace Scripter.Lib.Tests;

public class LogAppsBuildAllTests 
    : LibTest
{
    private static IProjectList projsLibsList
        = new LogAppsList(
            new SumingProjExtractor()
            , new List<ICodeData> 
            {
                new ModernLogData()
                , new ModernWizardLogData()
                , new ModernMDILogData()
                , new ConsoleLogData()
            });

    [Theory]
    //ModernApp
    //IndependantLibData
    [InlineData(0, $"& \"$PSScriptRoot\\EFCoreHelper.Build.ps1\"")]
    [InlineData(1, $"& \"$PSScriptRoot\\DIHelper.Build.ps1\"")]
    //OneRefLibData
    [InlineData(2, $"& \"$PSScriptRoot\\CLIHelper.Build.ps1\"")]
    [InlineData(3, $"& \"$PSScriptRoot\\Config.Wrapper.Build.ps1\"")]
    [InlineData(4, $"& \"$PSScriptRoot\\ModelHelper.Build.ps1\"")]
    //TwoRefLibData
    [InlineData(5, $"& \"$PSScriptRoot\\DataToTable.Build.ps1\"")]
    //CommandDotNetLibData
    [InlineData(6, $"& \"$PSScriptRoot\\CommandDotNet.Helper.Build.ps1\"")]
    [InlineData(7, $"& \"$PSScriptRoot\\CommandDotNet.IoC.Unity.Build.ps1\"")]
    [InlineData(8, $"& \"$PSScriptRoot\\CommandDotNet.Unity.Helper.Build.ps1\"")]
    //ManyRefLibData
    [InlineData(9, $"& \"$PSScriptRoot\\Serilog.Wrapper.Build.ps1\"")]
    [InlineData(10, $"& \"$PSScriptRoot\\CRUDCommandHelper.Build.ps1\"")]
    //Log
    [InlineData(11, $"& \"$PSScriptRoot\\Log.Data.Build.ps1\"")]
    [InlineData(12, $"& \"$PSScriptRoot\\Log.Table.Build.ps1\"")]
    [InlineData(13, $"& \"$PSScriptRoot\\DotNetExtension.Build.ps1\"")]
    [InlineData(14, $"& \"$PSScriptRoot\\Log.Modern.Lib.Build.ps1\"")]
    [InlineData(15, $"& \"$PSScriptRoot\\Log.Modern.ConsoleApp.Build.ps1\"")]
    //ModernWizardApp
    //TwoRefLibData
    [InlineData(16, "& \"$PSScriptRoot\\CLIReader.Build.ps1\"")]
    //ManyRefLibData
    [InlineData(17, "& \"$PSScriptRoot\\CLIWizardHelper.Build.ps1\"")]
    //Log
    [InlineData(18, "& \"$PSScriptRoot\\Log.Wizard.Lib.Build.ps1\"")]
    [InlineData(19, "& \"$PSScriptRoot\\Log.Modern.Wizard.ConsoleApp.Build.ps1\"")]
    //MDIModernApp
    //CommandDotNetLibData
    [InlineData(20, "& \"$PSScriptRoot\\CommandDotNet.MDI.Helper.Build.ps1\"")]
    //Log
    [InlineData(21, "& \"$PSScriptRoot\\Log.Modern.MDI.ConsoleApp.Build.ps1\"")]
    //ConsoleFramworkApp
    //ManyRefLibData
    [InlineData(22, $"& \"$PSScriptRoot\\CLIFramework.Build.ps1\"")]
    //Log
    [InlineData(23, $"& \"$PSScriptRoot\\Log.Console.Lib.Build.ps1\"")]
    [InlineData(24, $"& \"$PSScriptRoot\\Log.ConsoleApp.Build.ps1\"")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        IScript script = new ProjsBuildAllScript(
            projsLibsList
            , new BuildAllDTO("Log.Apps.BuildAll.ps1"));

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}