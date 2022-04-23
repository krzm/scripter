using Moq;

namespace Scripter.Lib.Tests;

public abstract class ScriptTestBase
{
    public abstract void TestScriptContent(
        int index
        , string expected);

    protected abstract Mock<IScriptParam> SetupParamsMock(
        ParamsMockData d);

    protected static string GetLine(
        IScript script
        , int index)
    {
        return script.GetScript()[index];
    }
}