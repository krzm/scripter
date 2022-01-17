using Moq;
using Xunit;

namespace Scripter.Lib.Tests;

public class VersionScriptTests
{
    [Theory]
    [InlineData(
        "Log.Modern.ConsoleApp"
        , @"$scriptFolder = C:\kmazanek@gmail.com\Code\PowerShell\Log.Modern.ConsoleApp\r\n")]
    public void TestCorrectnessOfScript(
        string projectName
        , string expected)
    {
        var moq = new Mock<IScriptVariables>();
        moq.Setup(m => m.ScriptPath).Returns($@"C:\kmazanek@gmail.com\Code\PowerShell\{projectName}");
        IVersionScript script = new VersionScript(moq.Object);

        var acctual = script.GetScript();

        Assert.Equal(expected, acctual);
    }
}