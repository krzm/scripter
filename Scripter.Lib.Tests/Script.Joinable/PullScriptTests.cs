using Moq;
using Xunit;

namespace Scripter.Lib.Tests;

public class PullScriptTests 
    : LibTest
{
    [Theory]
    [InlineData(0, "$codeFolder = \"C:\\kmazanek@gmail.com\\Code\"")]
    [InlineData(1, "$scriptFolder = \"C:\\kmazanek@gmail.com\\Build.Script\"")]
    [InlineData(2, "$proj = \"cli-helper\"")]
    [InlineData(3, "Set-Location $codeFolder")]
    [InlineData(4, "$projPath = $codeFolder + \"\\\" + $proj")]
    [InlineData(5, "if(-not (Test-Path $projPath))")]
    [InlineData(6, "{")]
    [InlineData(7, "    Write-Output \"$proj - No Proj in path: $projPath\"")]
    [InlineData(8, "}")]
    [InlineData(9, "else")]
    [InlineData(10, "{")]
    [InlineData(11, "   Set-Location $projPath")]
    [InlineData(12, "   $result = git pull")]
    [InlineData(13, "   Write-Output \"$proj - $result\"")]
    [InlineData(14, "}")]
    [InlineData(15, "Set-Location $scriptFolder")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        var moq = new Mock<IScriptParam>();
        SetupParams(moq);
        IScript script = new PullScript(moq.Object);

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}