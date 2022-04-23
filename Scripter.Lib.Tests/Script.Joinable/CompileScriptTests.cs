using Xunit;

namespace Scripter.Lib.Tests;

public class CompileScriptTests 
    : ScriptTest
{
    [Theory]
    [InlineData(0, $"Set-Location -Path \"C:\\kmazanek@gmail.com\\Code\\cli-helper\"")]
    [InlineData(1, $"dotnet build")]
    [InlineData(2, $"dotnet build --configuration Release")]
    [InlineData(3, $"dotnet test")]
    [InlineData(4, $"dotnet publish -c Release")]
    [InlineData(5, $"Set-Location -Path \"C:\\kmazanek@gmail.com\\Build.Script\"")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        var moq = SetupParamsMock(new ParamsMockData());
        IScript script = new CompileScript(moq.Object);

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}