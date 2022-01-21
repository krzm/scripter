using Moq;

namespace Scripter.Lib.Tests;

public abstract class ScriptTests
{
    protected static void SetupParams(
       Mock<IScriptParam> moq)
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

    protected static string GetLine(
        IScript script
        , int index)
    {
        return script.GetScript()[index];
    }
}