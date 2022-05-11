using Xunit;

namespace Scripter.Lib.Tests;

public class CopyScriptTests 
    : ScriptTest
{
    [Theory]
    [MemberData(nameof(CopyScriptData.Data), MemberType= typeof(CopyScriptData))]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        var moq = SetupParamsMock(new ParamsMockData());
        IScript script = new CopyBuildScript(moq.Object);

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}