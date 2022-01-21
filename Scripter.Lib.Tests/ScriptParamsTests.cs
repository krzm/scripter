using Xunit;

namespace Scripter.Lib.Tests;

public class ScriptParamsTests
{
    [Theory]
    [InlineData("Log.Modern.ConsoleApp")]
    public void TestProjectName(string expected)
    {
        var sut = GetSut();

        Assert.Equal(sut.ProjectName, expected);
    }

    [Fact]
    public void TestVerionFileName()
    {
        var sut = GetSut();

        Assert.Equal("Version.xml", sut.VersionFileName);
    }

    [Theory]
    [InlineData(@"C:\kmazanek@gmail.com\Code\PowerShell\Log.Modern.ConsoleApp")]
    public void TestScriptPath(string expected)
    {
        var sut = GetSut();

        Assert.Equal(expected, sut.ScriptPath);
    }

    [Theory]
    [InlineData(@"C:\kmazanek@gmail.com\Apps")]
    public void TestAppsPath(string expected)
    {
        var sut = GetSut();

        Assert.Equal(expected, sut.BuildPath);
    }

    [Theory]
    [InlineData(@"C:\kmazanek@gmail.com\Code\Log.Modern.ConsoleApp")]
    public void TestRepoPath(string expected)
    {
        var sut = GetSut();

        Assert.Equal(expected, sut.RepoPath);
    }

    private static IScriptParam GetSut()
    {
        return new ScriptParam
        {
            ProjectName = "Log.Modern.ConsoleApp"
        };
    }
}