using Xunit;

namespace Scripter.Lib.Tests;

public class ScriptVariablesTests
{
    [Theory]
    [InlineData("Log.Modern.ConsoleApp")]
    public void TestCorrectnessOfProjectName(string expected)
    {
        IScriptVariables sut = GetSut();

        Assert.Equal(sut.ProjectName, expected);
    }

    private static IScriptVariables GetSut()
    {
        return new ScriptVariables
        {
            ProjectName = "Log.Modern.ConsoleApp"
        };
    }

    [Fact]
    public void TestCorrectnessOfVerionFileName()
    {
        IScriptVariables sut = GetSut();

        Assert.Equal("Version.xml", sut.VersionFileName);
    }

    [Theory]
    [InlineData(@"C:\kmazanek@gmail.com\Code\PowerShell\Log.Modern.ConsoleApp")]
    public void TestCorrectnessOfScriptPath(string expected)
    {
        IScriptVariables sut = GetSut();

        Assert.Equal(expected, sut.ScriptPath);
    }

    [Theory]
    [InlineData(@"C:\kmazanek@gmail.com\Apps")]
    public void TestCorrectnessOfAppsPath(string expected)
    {
        IScriptVariables sut = GetSut();

        Assert.Equal(expected, sut.BuildPath);
    }

    [Theory]
    [InlineData(@"C:\kmazanek@gmail.com\Code\Log.Modern.ConsoleApp")]
    public void TestCorrectnessOfRepoPath(string expected)
    {
        IScriptVariables sut = GetSut();

        Assert.Equal(expected, sut.RepoPath);
    }
}