using Moq;
using System.IO;

namespace Scripter.Lib.Tests;

public abstract class ScriptTestBase
{
    public abstract void TestScriptContent(
        int index
        , string expected);

    protected static void SetupParams(
       Mock<IScriptParam> moq)
    {
        var repoFolder = "AppStarter";
        var appProjFolder = "AppStarter.ConsoleApp";
        var versionFileName = "Version.xml";
        var rootPath = @"C:\kmazanek@gmail.com";
        var appsFolder = "Apps";
        var buildPath = Path.Combine(rootPath, appsFolder);
        var codeFolder = "Code";
        var scriptRelativePath = @"PowerShell\Build";
        var scriptPath = Path.Combine(rootPath, codeFolder, scriptRelativePath);
        var repoPath = Path.Combine(rootPath, codeFolder, repoFolder);

        moq.Setup(m => m.Project).Returns(new ProjectDTO(repoFolder, appProjFolder));
        moq.Setup(m => m.VersionFileName).Returns(versionFileName);
        moq.Setup(m => m.BuildPath).Returns(buildPath);
        moq.Setup(m => m.ScriptPath).Returns(scriptPath);
        moq.Setup(m => m.RepoPath).Returns(repoPath);
    }

    protected static string GetLine(
        IScript script
        , int index)
    {
        return script.GetScript()[index];
    }
}