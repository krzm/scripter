using Moq;
using Xunit;

namespace Scripter.Lib.Tests;

public class VersionScriptTests
{
    [Theory]
    [InlineData(
        0
        , "$projectName = \"Log.Modern.ConsoleApp\""
        )]
    [InlineData(
        1
        , "$versionFileName = \"Version.xml\""
        )]
    [InlineData(
        2
        , "$buildPath = \"C:\\kmazanek@gmail.com\\Apps\""
        )]
    [InlineData(
        3
        , "$scriptPath = \"C:\\kmazanek@gmail.com\\Code\\PowerShell\\Log.Modern.ConsoleApp\""
        )]
    [InlineData(
        4
        , "$repoPath = \"C:\\kmazanek@gmail.com\\Code\\Log.Modern.ConsoleApp\""
        )]
    [InlineData(
        5
        , ""
        )]
    [InlineData(
        6
        , "Set-Location -Path $repoPath"
        )]
    [InlineData(
        7
        , "$sh1 = git rev-parse HEAD"
        )]
    [InlineData(
        8
        , ""
        )]
    [InlineData(
        9
        , "Set-Location -Path $buildPath"
        )]
    [InlineData(
        10
        , "$versionFilePath = $buildPath + \"\\\" + $versionFileName"
        )]
    [InlineData(
        11
        , "$hashTable = Import-Clixml $versionFilePath"
        )]
    [InlineData(
        12
        , "$hashTable[$projectName] = $sh1"
        )]
    [InlineData(
        13
        , "$hashTable | Export-Clixml -Path $versionFilePath"
        )]
    [InlineData(
        14
        , "Set-Location -Path $scriptPath"
        )]
    public void TestCorrectnessOfScript(
        int index
        , string expected)
    {
        var moq = new Mock<IScriptVariables>();
        SetupParams(moq);
        IScript script = new VersionScript(moq.Object);

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
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

    private static string GetLine(
        IScript script
        , int index)
    {
        return script.GetScript()[index];
    }
}