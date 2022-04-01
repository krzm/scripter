using System.Collections.Generic;
using Xunit;

namespace Scripter.Lib.Tests;

public class LogAppsBuildAllTests 
    : LibTest
{
    private static IProjectList projList
        = new AllProjList(
            new ProjectExtractor()
            , new List<ICodeData> 
            {
                new ModernLogData()
                //, new ModernWizardLogData()
                //, new ModernMDILogData()
                //, new ConsoleLogData()
            });

    [Theory]
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
    public override void TestScriptContent(
        int index
        , string expected)
    {
        IScript script = new BuildAllScript(
            projList
            , new BuildAllDTO("LogAppsBuildAll.ps1"));
   
        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}