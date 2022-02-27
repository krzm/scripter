using Moq;

namespace Scripter.Lib.Tests;

public abstract class ScriptTestBase
{
    public abstract void TestScriptContent(
        int index
        , string expected);

    protected abstract void SetupParams(
       Mock<IScriptParam> moq);

    protected static string GetLine(
        IScript script
        , int index)
    {
        return script.GetScript()[index];
    }
}