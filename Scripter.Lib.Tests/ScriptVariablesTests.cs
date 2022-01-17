using System;
using Xunit;

namespace Scripter.Lib.Tests;

public class ScriptVariablesTests
{
    [Theory]
    [InlineData(@"Log.Modern.ConsoleApp")]
    public void TestCorrectnessOfProjectName(string expected)
    {
        IScriptVariables folders = new ScriptVariables(expected);

        Assert.Equal(folders.ProjectName, expected);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void TestProjectNameNullException(string param)
    {
        Assert.Throws<ArgumentNullException>(() => new ScriptVariables(param));
    }

    [Fact]
    public void TestCorrectnessOfVerionFileName()
    {
        IScriptVariables folders = new ScriptVariables("Log.Modern.ConsoleApp");

        Assert.Equal("Version.xml", folders.VersionFileName);
    }

    [Theory]
    [InlineData(@"C:\kmazanek@gmail.com\Code\PowerShell\Log.Modern.ConsoleApp")]
    public void TestCorrectnessOfScriptPath(string expected)
    {
        IScriptVariables folders = new ScriptVariables("Log.Modern.ConsoleApp");

        Assert.Equal(expected, folders.ScriptPath);
    }

    [Theory]
    [InlineData(@"C:\kmazanek@gmail.com\Apps")]
    public void TestCorrectnessOfAppsPath(string expected)
    {
        IScriptVariables folders = new ScriptVariables("Log.Modern.ConsoleApp");

        Assert.Equal(expected, folders.BuildPath);
    }

    [Theory]
    [InlineData(@"C:\kmazanek@gmail.com\Code\Log.Modern.ConsoleApp")]
    public void TestCorrectnessOfRepoPath(string expected)
    {
        IScriptVariables folders = new ScriptVariables("Log.Modern.ConsoleApp");

        Assert.Equal(expected, folders.RepoPath);
    }
}