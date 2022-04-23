using Moq;
using Xunit;

namespace Scripter.Lib.Tests;

public class CloneScriptTests 
    : ScriptTest
{
    [Theory]
    [InlineData(0, "$repoPath = \"C:\\kmazanek@gmail.com\\Code\\cli-helper\"")]
    [InlineData(1, "$codePath = \"C:\\kmazanek@gmail.com\\Code")]
    [InlineData(2, "$scriptPath = \"C:\\kmazanek@gmail.com\\Build.Script")]
    [InlineData(3, "$proj = \"cli-helper\"")]
    [InlineData(4, "$http = \"https://github.com/krzm/\"")]
    [InlineData(5, "$end = \".git\"")]
    [InlineData(6, "$url = $http + $proj + $end")]
    [InlineData(7, "if(-not (Test-Path $repoPath))")]
    [InlineData(8, "{")]
    [InlineData(9, "	Set-Location $codePath")]
    [InlineData(10, "	$result = git clone $url")]
    [InlineData(11, "	Write-Output \"$proj - $result\"")]
    [InlineData(12, "}")]
    [InlineData(13, "else")]
    [InlineData(14, "{")]
    [InlineData(15, "	Write-Output \"$proj - Repo already cloned\"")]
    [InlineData(16, "}")]
    [InlineData(17, "Set-Location $scriptPath")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        var moq = new Mock<IScriptParam>();
        SetupParams(moq);
        IScript script = new CloneScript(moq.Object);

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}