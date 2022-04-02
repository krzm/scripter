using System.Collections.Generic;
using Xunit;

namespace Scripter.Lib.Tests;

public class LibsBuildAllTests 
    : LibTest
{
    private static IProjectList projList
        = new AllProjList(
            new ResetingProjExtractor()
            , new List<ICodeData> 
            {
                new ManyRefLibData()
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
    public override void TestScriptContent(
        int index
        , string expected)
    {
        IScript script = new BuildAllScript(
            projList
            , new BuildAllDTO("LibBuildAll.ps1"));
   
        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}