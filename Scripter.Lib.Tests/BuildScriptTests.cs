using Moq;
using Xunit;

namespace Scripter.Lib.Tests;

public class BuildScriptTests : ScriptTestBase
{
    [Theory]
    [InlineData(0, $"& \"$PSScriptRoot\\Log.Modern.ConsoleApp.Compile.ps1\"")]
    [InlineData(1, $"& \"$PSScriptRoot\\Log.Modern.ConsoleApp.Version.ps1\"")]
    [InlineData(2, $"& \"$PSScriptRoot\\Log.Modern.ConsoleApp.Copy.ps1\"")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        var moq = new Mock<IScriptParam>();
        SetupParams(moq);
        IScript script = new BuildScript(moq.Object);

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}