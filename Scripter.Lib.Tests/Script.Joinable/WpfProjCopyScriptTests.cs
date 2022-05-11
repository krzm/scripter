using Xunit;

namespace Scripter.Lib.Tests;

public class WpfProjCopyScriptTests 
    : ScriptTest
{
    [Theory]
    [MemberData(nameof(WpfProjCopyScriptData.Data), MemberType= typeof(WpfProjCopyScriptData))]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        var moq = SetupParamsMock(new ParamsMockData(IsWpf:true));
        IScript script = new CopyBuildWpfScript(moq.Object);

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}