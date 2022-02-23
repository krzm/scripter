using Moq;
using Xunit;

namespace Scripter.Lib.Tests;

public class CopyAppScriptTests : ScriptTestBase
{
    [Theory]
    [InlineData(0, "$buildPath1 = \"C:\\kmazanek@gmail.com\\Build\\cli-helper\\CLIHelper\"")]
    [InlineData(1, "$appsPath1 = \"C:\\kmazanek@gmail.com\\Apps\"")]
    [InlineData(2, "$buildPath2 = \"C:\\kmazanek@gmail.com\\Build\\cli-helper\\CLIHelper\\*\"")]
    [InlineData(3, "$appsPath2 = \"C:\\kmazanek@gmail.com\\Apps\\CLIHelper\"")]
    [InlineData(4, "$buildPath3 = \"C:\\kmazanek@gmail.com\\Build\\Version.csv\"")]
    [InlineData(5, "Copy-Item -Path $buildPath1 -Destination $appsPath1")]
    [InlineData(6, "Copy-Item -Path $buildPath2 -Destination $appsPath2 -Recurse")]
    [InlineData(7, "Copy-Item -Path $buildPath3 -Destination $appsPath1")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        var moq = new Mock<IScriptParam>();
        SetupParams(moq);
        IScript script = new CopyAppScript(moq.Object);

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}