using System;
using Xunit;

namespace Scripter.Lib.Tests;

public class ScriptVariablesTests
{
    [Theory]
    [InlineData(@"Log.Modern.ConsoleApp")]
    public void TestCorrectnessOfProjectName(string expected)
    {
        IScriptVariables scriptVariables = new ScriptVariables(expected);

        Assert.Equal(scriptVariables.ProjectName, expected);
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
        IScriptVariables scriptVariables = new ScriptVariables("Log.Modern.ConsoleApp");

        Assert.Equal("Version.xml", scriptVariables.VersionFileName);
    }

    [Theory]
    [InlineData(@"C:\kmazanek@gmail.com\Code\PowerShell\Log.Modern.ConsoleApp")]
    public void TestCorrectnessOfScriptPath(string expected)
    {
        IScriptVariables scriptVariables = new ScriptVariables("Log.Modern.ConsoleApp");

        Assert.Equal(expected, scriptVariables.ScriptPath);
    }

    [Theory]
    [InlineData(@"C:\kmazanek@gmail.com\Apps")]
    public void TestCorrectnessOfAppsPath(string expected)
    {
        IScriptVariables scriptVariables = new ScriptVariables("Log.Modern.ConsoleApp");

        Assert.Equal(expected, scriptVariables.BuildPath);
    }

    [Theory]
    [InlineData(@"C:\kmazanek@gmail.com\Code\Log.Modern.ConsoleApp")]
    public void TestCorrectnessOfRepoPath(string expected)
    {
        IScriptVariables scriptVariables = new ScriptVariables("Log.Modern.ConsoleApp");

        Assert.Equal(expected, scriptVariables.RepoPath);
    }
}