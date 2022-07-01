using Xunit;

namespace Scripter.Lib.Tests;

public class ScriptParamTests : ScriptParamTestBase
{
    [Theory]
    [InlineData(nameof(ScriptParam.Project.RepoFolder), "cli-helper")]
    [InlineData(nameof(ScriptParam.Project.ProjFolder), "CLIHelper")]
    [InlineData(nameof(ScriptParam.XmlVersionFile), "Version.xml")]
    [InlineData(nameof(ScriptParam.CodePath), @"C:\kmazanek.gmail.com\Code")]
    [InlineData(nameof(ScriptParam.BuildPath), @"C:\kmazanek.gmail.com\Build")]
    [InlineData(nameof(ScriptParam.RepoPath), @"C:\kmazanek.gmail.com\Code\cli-helper")]
    [InlineData(nameof(ScriptParam.ScriptPath), @"C:\kmazanek.gmail.com\Build.Script")]
    [InlineData(nameof(ScriptParam.CloneUrlStart), @"https://github.com/krzm/")]
    [InlineData(nameof(ScriptParam.CloneUrlEnd), ".git")]
    [InlineData(nameof(ScriptParam.CloneUrl), @"https://github.com/krzm/cli-helper.git")]
    public override void TestParams(
        string propName
        , string expected)
    {
        var sut = GetSut();

        var acctual = SelectProp(sut, propName);

        Assert.Equal(expected, acctual);
    }    
}