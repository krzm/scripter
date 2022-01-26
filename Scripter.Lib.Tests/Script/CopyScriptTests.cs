using Moq;
using Xunit;

namespace Scripter.Lib.Tests;

public class CopyScriptTests : ScriptTestBase
{
    [Theory]
    [InlineData(0, $"Remove-Item \"C:\\kmazanek@gmail.com\\Apps\\AppStarter\\*\" -Recurse")]
    [InlineData(1, "New-Item -Path \"C:\\kmazanek@gmail.com\\Apps\\AppStarter\\\" -Name \"AppStarter.ConsoleApp\" -ItemType \"directory\"")]
    [InlineData(2, $"Copy-Item -Path \"C:\\kmazanek@gmail.com\\Code\\AppStarter\\AppStarter.ConsoleApp\\bin\\Release\\net6.0\\publish\\*\" -Destination \"C:\\kmazanek@gmail.com\\Apps\\AppStarter\\AppStarter.ConsoleApp\" -Recurse")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        var moq = new Mock<IScriptParam>();
        SetupParams(moq);
        IScript script = new CopyScript(moq.Object);

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}