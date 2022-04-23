using Moq;

namespace Scripter.Lib.Tests;

public abstract class ScriptTest
    : ScriptTestBase
{
    protected override Mock<IScriptParam> SetupParamsMock(
        ParamsMockData d)
    {
        var moq = new Mock<IScriptParam>();
        moq.Setup(m => m.Project).Returns(
            new ProjectDTO(
                d.RepoFolder
                , d.AppProjFolder
                , IsApp: d.IsApp));
        moq.Setup(m => m.VersionFileName)
            .Returns(d.VersionFileName);
        moq.Setup(m => m.CodePath)
            .Returns(d.CodePath);
        moq.Setup(m => m.BuildPath)
            .Returns(d.BuildPath);
        moq.Setup(m => m.ScriptPath)
            .Returns(d.ScriptPath);
        moq.Setup(m => m.RepoPath)
            .Returns(d.RepoPath);
        return moq;
    }
}