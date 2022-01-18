using Moq;
using Xunit;

namespace Scripter.Lib.Tests;

public class VersionScriptTests
{
    [Theory]
    [InlineData(
        "Log.Modern.ConsoleApp"
        , @"$scriptPath = C:\kmazanek@gmail.com\Code\PowerShell\Log.Modern.ConsoleApp\r\n"
        + @"$appsPath = C:\kmazanek@gmail.com\Apps\r\n"
        + @"$repoPath = C:\kmazanek@gmail.com\Code\Log.Modern.ConsoleApp\r\n")]
    public void TestCorrectnessOfScript(
        string projectName
        , string expected)
    {
        var moq = new Mock<IScriptVariables>();
        moq.Setup(m => m.ScriptPath).Returns(
            $@"C:\kmazanek@gmail.com\Code\PowerShell\{projectName}");
        moq.Setup(m => m.BuildPath).Returns(
            $@"C:\kmazanek@gmail.com\Apps");
        moq.Setup(m => m.RepoPath).Returns(
            $@"C:\kmazanek@gmail.com\Code\{projectName}");
        IVersionScript script = new VersionScript(moq.Object);

        var acctual = script.GetScript();

        Assert.Equal(expected, acctual);
    }
}