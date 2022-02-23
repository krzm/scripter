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
        var repoFolder = "cli-helper";
        var appProjFolder = "CLIHelper";
        var versionFileName = "Version.xml";
        var rootPath = @"C:\kmazanek@gmail.com";
        var codeFolder = "Code";
        var repoPath = Path.Combine(rootPath, codeFolder, repoFolder);

        moq.Setup(m => m.Project).Returns(new ProjectDTO(repoFolder, appProjFolder));
        moq.Setup(m => m.VersionFileName).Returns(versionFileName);
        moq.Setup(m => m.BuildPath).Returns(@"C:\kmazanek@gmail.com\Build");
        moq.Setup(m => m.ScriptPath).Returns(@"C:\kmazanek@gmail.com\Build.Script");
        moq.Setup(m => m.RepoPath).Returns(repoPath);
    }

    protected static string GetLine(
        IScript script
        , int index)
    {
        return script.GetScript()[index];
    }
}