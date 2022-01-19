using Moq;
using Xunit;

namespace Scripter.Lib.Tests;

public class VersionScriptTests
{
    [Theory]
    [InlineData(
        0
        , "$projectName = \"Log.Modern.ConsoleApp\"\r\n"
        )]
    [InlineData(
        1
        , "$versionFileName = \"Version.xml\"\r\n"
        )]
    [InlineData(
        2
        , "$buildPath = \"C:\\kmazanek@gmail.com\\Apps\"\r\n"
        )]
    [InlineData(
        3
        , "$scriptPath = \"C:\\kmazanek@gmail.com\\Code\\PowerShell\\Log.Modern.ConsoleApp\"\r\n"
        )]
    [InlineData(
        4
        , "$repoPath = \"C:\\kmazanek@gmail.com\\Code\\Log.Modern.ConsoleApp\"\r\n"
        )]
    [InlineData(
        5
        , "\r\n"
        )]
    [InlineData(
        6
        , "Set-Location -Path $repoPath\r\n"
        )]
    [InlineData(
        7
        , "$sh1 = git rev-parse HEAD\r\n"
        )]
    [InlineData(
        8
        , "\r\n"
        )]
    [InlineData(
        9
        , "Set-Location -Path $buildPath\r\n"
        )]
    public void TestCorrectnessOfScript(
        int index
        , string expected)
    {
        var moq = new Mock<IScriptVariables>();
        SetupParams(moq);
        IVersionScript script = new VersionScript(moq.Object);

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }

    private static string GetLine(
        IVersionScript script
        , int index)
    {
        return script.GetScript()[index];
    }

    private static void SetupParams(
        Mock<IScriptVariables> moq)
    {
        moq.Setup(m => m.ProjectName).Returns(
            "Log.Modern.ConsoleApp");
        moq.Setup(m => m.VersionFileName).Returns(
            "Version.xml");
        moq.Setup(m => m.BuildPath).Returns(
            @"C:\kmazanek@gmail.com\Apps");
        moq.Setup(m => m.ScriptPath).Returns(
            @"C:\kmazanek@gmail.com\Code\PowerShell\Log.Modern.ConsoleApp");
        moq.Setup(m => m.RepoPath).Returns(
            @"C:\kmazanek@gmail.com\Code\Log.Modern.ConsoleApp");
    }
}