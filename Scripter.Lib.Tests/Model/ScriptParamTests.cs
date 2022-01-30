using Xunit;

namespace Scripter.Lib.Tests;

public class ScriptParamTests : ScriptParamTestBase
{
    [Theory]
    [InlineData(nameof(ScriptParam.Project.RepoFolder), "cli-helper")]
    [InlineData(nameof(ScriptParam.Project.AppProjFolder), "CLIHelper")]
    [InlineData(nameof(ScriptParam.VersionFileName), "Version.xml")]
    [InlineData(nameof(ScriptParam.ScriptPath), @"C:\kmazanek@gmail.com\Code\build\Script")]
    [InlineData(nameof(ScriptParam.BuildPath), @"C:\kmazanek@gmail.com\Code\build\Build")]
    [InlineData(nameof(ScriptParam.RepoPath), @"C:\kmazanek@gmail.com\Code\cli-helper")]
    public override void TestScriptParamContent(
        string propName
        , string expected)
    {
        var sut = GetSut();

        Assert.Equal(expected, SelectProp(sut, propName));
    }    
}