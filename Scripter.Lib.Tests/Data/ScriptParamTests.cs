using Xunit;

namespace Scripter.Lib.Tests;

public class ScriptParamTests : ScriptParamTestBase
{
    [Theory]
    [InlineData(nameof(ScriptParam.Project.RepoFolder), "cli-helper")]
    [InlineData(nameof(ScriptParam.Project.ProjFolder), "CLIHelper")]
    [InlineData(nameof(ScriptParam.VersionFileName), "Version.xml")]
    [InlineData(nameof(ScriptParam.CodePath), @"C:\kmazanek@gmail.com\Code")]
    [InlineData(nameof(ScriptParam.BuildPath), @"C:\kmazanek@gmail.com\Build")]
    [InlineData(nameof(ScriptParam.RepoPath), @"C:\kmazanek@gmail.com\Code\cli-helper")]
    [InlineData(nameof(ScriptParam.ScriptPath), @"C:\kmazanek@gmail.com\Build.Script")]
    public override void TestParams(
        string propName
        , string expected)
    {
        var sut = GetSut();

        var acctual = SelectProp(sut, propName);

        Assert.Equal(expected, acctual);
    }    
}