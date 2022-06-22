using Xunit;

namespace Scripter.Lib.Tests;

public class BuildScriptTests 
    : ScriptTest
{
    [Theory]
    [InlineData(0, $"& \"$PSScriptRoot\\CLIHelper.Clone.ps1\"")]
    [InlineData(1, $"& \"$PSScriptRoot\\CLIHelper.Pull.ps1\"")]
    [InlineData(2, $"& \"$PSScriptRoot\\CLIHelper.Test.ps1\"")]
    [InlineData(3, $"& \"$PSScriptRoot\\CLIHelper.Compile.ps1\"")]
    [InlineData(4, $"& \"$PSScriptRoot\\CLIHelper.Version.ps1\"")]
    [InlineData(5, $"& \"$PSScriptRoot\\CLIHelper.Copy.ps1\"")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        var moq = SetupParamsMock(new ParamsMockData());
        IScript script = new BuildScript(moq.Object);

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }

    [Theory]
    [InlineData(0, $"& \"$PSScriptRoot\\CLIHelper.Clone.ps1\"")]
    [InlineData(1, $"& \"$PSScriptRoot\\CLIHelper.Pull.ps1\"")]
    [InlineData(2, $"& \"$PSScriptRoot\\CLIHelper.Test.ps1\"")]
    [InlineData(3, $"& \"$PSScriptRoot\\CLIHelper.Compile.ps1\"")]
    [InlineData(4, $"& \"$PSScriptRoot\\CLIHelper.Version.ps1\"")]
    [InlineData(5, $"& \"$PSScriptRoot\\CLIHelper.Copy.ps1\"")]
    [InlineData(6, $"& \"$PSScriptRoot\\CLIHelper.CopyApp.ps1\"")]
    public void TestAppScriptContent(
        int index
        , string expected)
    {
        var moq = SetupParamsMock(new ParamsMockData(IsApp:true));
        IScript script = new AppBuildScript(moq.Object);

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}