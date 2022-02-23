using Moq;
using Xunit;

namespace Scripter.Lib.Tests;

public class VersionScriptTests : ScriptTestBase
{
    [Theory]
    [InlineData(0, "$projectName = \"CLIHelper\"")]
    [InlineData(1, "$versionFileName = \"Version.xml\"")]
    [InlineData(2, "$buildPath = \"C:\\kmazanek@gmail.com\\Code\\build\\Build\"")]
    [InlineData(3, "$scriptPath = \"C:\\kmazanek@gmail.com\\Code\\build\\Script\"")]
    [InlineData(4, "$repoPath = \"C:\\kmazanek@gmail.com\\Code\\cli-helper\"")]
    [InlineData(5, "")]
    [InlineData(6, "Set-Location -Path $repoPath")]
    [InlineData(7, "$sh1 = git rev-parse HEAD")]
    [InlineData(8, "")]
    [InlineData(9, "Set-Location -Path $buildPath")]
    [InlineData(10, "$versionFilePath = $buildPath + \"\\\" + $versionFileName")]
    [InlineData(11, "if (-not (Test-Path $versionFilePath))")]
    [InlineData(12, "{")]
    [InlineData(13, "$hashTable = @{}")]
    [InlineData(14, "$hashTable.Add($projectName, $sh1)")]
    [InlineData(15, "}")]
    [InlineData(16, "else")]
    [InlineData(17, "{")]
    [InlineData(18, "$hashTable = Import-Clixml $versionFilePath")]
    [InlineData(19, "$hashTable[$projectName] = $sh1")]
    [InlineData(20, "}")]
    [InlineData(21, "$hashTable | Export-Clixml -Path $versionFilePath")]
    [InlineData(22, "$versionFilePathCsv = $buildPath + \"\\Version.csv\"")]
    [InlineData(23, "$hashTable.GetEnumerator() |")]
    [InlineData(24, "Select-Object -Property @{N='Property';E={$_.Key}},")]
    [InlineData(25, "@{N='PropValue';E={$_.Value}} |")]
    [InlineData(26, "Export-Csv -NoTypeInformation -Path $versionFilePathCsv")]
    [InlineData(27, "Set-Location -Path $scriptPath")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        var moq = new Mock<IScriptParam>();
        SetupParams(moq);
        IScript script = new VersionScript(moq.Object);

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}