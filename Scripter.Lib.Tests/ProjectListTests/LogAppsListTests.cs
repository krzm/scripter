using System.Collections.Generic;
using Xunit;

namespace Scripter.Lib.Tests;

public class LogAppsListTests 
    : ProjListTestBase
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
    [InlineData(0, "EFCoreHelper")]
    [InlineData(1, "DIHelper")]
    //OneRefLibData
    [InlineData(2, "CLIHelper")]
    [InlineData(3, "Config.Wrapper")]
    [InlineData(4, "ModelHelper")]
    //TwoRefLibData
    [InlineData(5, "DataToTable")]
    //CommandDotNetLibData
    [InlineData(6, "CommandDotNet.Helper")]
    [InlineData(7, "CommandDotNet.IoC.Unity")]
    [InlineData(8, "CommandDotNet.Unity.Helper")]
    //ManyRefLibData
    [InlineData(9, "Serilog.Wrapper")]
    [InlineData(10, "CRUDCommandHelper")]
    //Log
    [InlineData(11, "Log.Data")]
    [InlineData(12, "Log.Table")]
    [InlineData(13, "DotNetExtension")]
    [InlineData(14, "Log.Modern.Lib")]
    [InlineData(15, "Log.Modern.ConsoleApp")]
    //ModernWizardApp
    //TwoRefLibData
    [InlineData(16, "CLIReader")]
    //ManyRefLibData
    [InlineData(17, "CLIWizardHelper")]
    //Log
    [InlineData(18, "Log.Wizard.Lib")]
    [InlineData(19, "Log.Modern.Wizard.ConsoleApp")]
    //MDIModernApp
    //CommandDotNetLibData
    [InlineData(20, "CommandDotNet.MDI.Helper")]
    //Log
    [InlineData(21, "Log.Modern.MDI.ConsoleApp")]
    //ConsoleFramworkApp
    //ManyRefLibData
    [InlineData(22, "CLIFramework")]
    //Log
    [InlineData(23, "Log.Console.Lib")]
    [InlineData(24, "Log.ConsoleApp")]
    public override void TestListContent(
        int index
        , string expected)
    {
        var acctual = GetItem(projsLibsList, index);

        Assert.Equal(expected, acctual);
    }
}