using Xunit;

namespace Scripter.Lib.Tests;

public class CopyScriptTests 
    : ScriptTest
{
    private const string buildPath = @"C:\kmazanek@gmail.com\Build";
    private const string repoFolder = "cli-helper";
    private const string appProjFolder = "CLIHelper";
    private const string repoBuildPath = @"C:\kmazanek@gmail.com\Build\cli-helper";  
    private const string appBuildPath = $@"{repoBuildPath}\{appProjFolder}";  
    
    [Theory]
    [InlineData(0, $"$path = \"{repoBuildPath}\"")]
    [InlineData(1, "if (-not (Test-Path $path))")]
    [InlineData(2, "{")]
    [InlineData(3, $"New-Item -Path \"{buildPath}\" -Name \"{repoFolder}\" -ItemType \"directory\"")]
    [InlineData(4, "}")]
    [InlineData(5, $"$path = \"{appBuildPath}\"")]
    [InlineData(6, "if (-not (Test-Path $path))")]
    [InlineData(7, "{")]
    [InlineData(8, $"New-Item -Path \"{repoBuildPath}\" -Name \"{appProjFolder}\" -ItemType \"directory\"")]
    [InlineData(9, "}")]
    [InlineData(10, "else")]
    [InlineData(11, "{")]
    [InlineData(12, $"Remove-Item \"{appBuildPath}\\*\" -Recurse")]
    [InlineData(13, "}")]
    [InlineData(14, $"Copy-Item -Path \"C:\\kmazanek@gmail.com\\Code\\cli-helper\\CLIHelper\\bin\\Release\\net6.0\\publish\\*\" -Destination \"C:\\kmazanek@gmail.com\\Build\\cli-helper\\CLIHelper\" -Recurse")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        var moq = SetupParamsMock(new ParamsMockData());
        IScript script = new CopyScript(moq.Object);

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}