using Moq;
using Xunit;

namespace Scripter.Lib.Tests;

public class AppBuildScriptTests 
    : ScriptTest
{
    [Theory]
    [InlineData(0, $"& \"$PSScriptRoot\\CLIHelper.Pull.ps1\"")]
    [InlineData(1, $"& \"$PSScriptRoot\\CLIHelper.Compile.ps1\"")]
    [InlineData(2, $"& \"$PSScriptRoot\\CLIHelper.Version.ps1\"")]
    [InlineData(3, $"& \"$PSScriptRoot\\CLIHelper.Copy.ps1\"")]
    [InlineData(4, $"& \"$PSScriptRoot\\CLIHelper.CopyApp.ps1\"")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        var moq = new Mock<IScriptParam>();
        SetupParams(moq, isApp: true);
        IScript script = new BuildScript(moq.Object);

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}