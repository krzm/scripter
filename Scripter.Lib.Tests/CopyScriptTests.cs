using Moq;
using Xunit;

namespace Scripter.Lib.Tests;

public class CopyScriptTests : ScriptTests
{
    [Theory]
    [InlineData(0, $"Remove-Item \"C:\\kmazanek@gmail.com\\Apps\\Log.Modern.ConsoleApp\\*\" -Recurse")]
    [InlineData(1, $"Copy-Item -Path \"C:\\kmazanek@gmail.com\\Code\\Log.Modern.ConsoleApp\\Log.Modern.ConsoleApp\\bin\\Release\\net6.0\\publish\\*\"")]
    public void TestCorrectnessOfScript(
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