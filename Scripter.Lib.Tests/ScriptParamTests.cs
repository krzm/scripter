using Xunit;

namespace Scripter.Lib.Tests;

public class ScriptParamTests : ScriptParamTestBase
{
    [Theory]
    [InlineData(nameof(ScriptParam.ProjectName), "Log.Modern.ConsoleApp")]
    [InlineData(nameof(ScriptParam.VersionFileName), "Version.xml")]
    [InlineData(nameof(ScriptParam.ScriptPath), @"C:\kmazanek@gmail.com\Code\PowerShell\Build")]
    [InlineData(nameof(ScriptParam.BuildPath), @"C:\kmazanek@gmail.com\Apps")]
    [InlineData(nameof(ScriptParam.RepoPath), @"C:\kmazanek@gmail.com\Code\Log.Modern.ConsoleApp")]
    public override void TestScriptParamContent(
        string propName
        , string expected)
    {
        var sut = GetSut();

        Assert.Equal(expected, SelectProp(sut, propName));
    }    
}