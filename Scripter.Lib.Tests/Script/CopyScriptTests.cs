using Moq;
using Xunit;

namespace Scripter.Lib.Tests;

public class CopyScriptTests : ScriptTestBase
{
    [Theory]
    [InlineData(0, $"Remove-Item \"C:\\kmazanek@gmail.com\\Code\\build\\Build\\cli-helper\\*\" -Recurse")]
    [InlineData(1, "New-Item -Path \"C:\\kmazanek@gmail.com\\Code\\build\\Build\\cli-helper\\\" -Name \"CLIHelper\" -ItemType \"directory\"")]
    [InlineData(2, $"Copy-Item -Path \"C:\\kmazanek@gmail.com\\Code\\cli-helper\\CLIHelper\\bin\\Release\\net6.0\\publish\\*\" -Destination \"C:\\kmazanek@gmail.com\\Code\\build\\Build\\cli-helper\\CLIHelper\" -Recurse")]
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