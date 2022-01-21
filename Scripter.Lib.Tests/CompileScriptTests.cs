using Moq;
using Xunit;

namespace Scripter.Lib.Tests;

public class CompileScriptTests
{
    [Theory]
    [InlineData(
        0
        , $"Set-Location -Path \"C:\\kmazanek@gmail.com\\Code\\Log.Modern.ConsoleApp\""
        )]
    [InlineData(
        1
        , $"dotnet build"
        )]
    [InlineData(
        2
        , $"dotnet publish -c Release"
        )]
    [InlineData(
        3
        , $"dotnet build --configuration Release"
        )]
    [InlineData(
        4
        , $"dotnet test"
        )]
    public void TestCorrectnessOfScript(
        int index
        , string expected)
    {
        var moq = new Mock<IScriptVariables>();
        SetupParams(moq);
        IScript script = new CompileScript(moq.Object);

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