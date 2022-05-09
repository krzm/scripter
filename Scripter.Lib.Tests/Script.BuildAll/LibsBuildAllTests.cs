using System.Collections.Generic;
using Scripter.Data;
using Scripter.Data.Helper;
using Xunit;

namespace Scripter.Lib.Tests;

public class LibsBuildAllTests 
    : ScriptTest
{
    private static IProjectList projList
        = new AllProjList(
            new ResetingProjExtractor()
            , new List<ICodeData> 
            {
                new ManyRefLibData()
            });

    [Theory]
    [InlineData(0, $"& \"$PSScriptRoot\\EFCoreHelper.Build.ps1\"")]
    [InlineData(1, $"& \"$PSScriptRoot\\DIHelper.Build.ps1\"")]
    [InlineData(2, $"& \"$PSScriptRoot\\DotNetExtension.Build.ps1\"")]
    [InlineData(3, $"& \"$PSScriptRoot\\DotNetTool.Build.ps1\"")]
    [InlineData(4, $"& \"$PSScriptRoot\\Vector.Lib.Build.ps1\"")]
    [InlineData(5, $"& \"$PSScriptRoot\\CLIHelper.Build.ps1\"")]
    [InlineData(6, $"& \"$PSScriptRoot\\Config.Wrapper.Build.ps1\"")]
    [InlineData(7, $"& \"$PSScriptRoot\\ModelHelper.Build.ps1\"")]
    [InlineData(8, $"& \"$PSScriptRoot\\CommandDotNet.Helper.Build.ps1\"")]
    [InlineData(9, $"& \"$PSScriptRoot\\CommandDotNet.MDI.Helper.Build.ps1\"")]
    [InlineData(10, $"& \"$PSScriptRoot\\CommandDotNet.IoC.Unity.Build.ps1\"")]
    [InlineData(11, $"& \"$PSScriptRoot\\CommandDotNet.Unity.Helper.Build.ps1\"")]
    [InlineData(12, $"& \"$PSScriptRoot\\CLIReader.Build.ps1\"")]
    [InlineData(13, $"& \"$PSScriptRoot\\DataToTable.Build.ps1\"")]
    [InlineData(14, $"& \"$PSScriptRoot\\Serilog.Wrapper.Build.ps1\"")]
    [InlineData(15, $"& \"$PSScriptRoot\\CRUDCommandHelper.Build.ps1\"")]
    [InlineData(16, $"& \"$PSScriptRoot\\CLIWizardHelper.Build.ps1\"")]
    [InlineData(17, $"& \"$PSScriptRoot\\CLIFramework.Build.ps1\"")]
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