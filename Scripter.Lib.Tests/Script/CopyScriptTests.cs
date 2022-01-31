using Moq;
using Xunit;

namespace Scripter.Lib.Tests;

public class CopyScriptTests : ScriptTestBase
{
    private const string buildPath = @"C:\kmazanek@gmail.com\Code\build\Build";
    private const string repoFolder = "cli-helper";
    private const string appProjFolder = "CLIHelper";
    private const string repoBuildPath = @"C:\kmazanek@gmail.com\Code\build\Build\cli-helper";  

    [Theory]
    [InlineData(0, $"$path = \"{repoBuildPath}\"")]
    [InlineData(1, "if (-not (Test-Path $path))")]
    [InlineData(2, "{")]
    [InlineData(3, $"New-Item -Path \"{buildPath}\" -Name \"{repoFolder}\" -ItemType \"directory\"")]
    [InlineData(4, "}")]
    [InlineData(5, $"Remove-Item \"C:\\kmazanek@gmail.com\\Code\\build\\Build\\cli-helper\\*\" -Recurse")]
    [InlineData(6, $"$path = \"{repoBuildPath}\\{appProjFolder}\"")]
    [InlineData(7, "if (-not (Test-Path $path))")]
    [InlineData(8, "{")]
    [InlineData(9, $"New-Item -Path \"{repoBuildPath}\" -Name \"{appProjFolder}\" -ItemType \"directory\"")]
    [InlineData(10, "}")]
    [InlineData(11, $"Copy-Item -Path \"C:\\kmazanek@gmail.com\\Code\\cli-helper\\CLIHelper\\bin\\Release\\net6.0\\publish\\*\" -Destination \"C:\\kmazanek@gmail.com\\Code\\build\\Build\\cli-helper\\CLIHelper\" -Recurse")]
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