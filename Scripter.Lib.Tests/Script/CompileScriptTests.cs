using Moq;
using Xunit;

namespace Scripter.Lib.Tests;

public class CompileScriptTests : ScriptTestBase
{
    [Theory]
    [InlineData(0, $"Set-Location -Path \"C:\\kmazanek@gmail.com\\Code\\AppStarter\"")]
    [InlineData(1, $"dotnet build")]
    [InlineData(2, $"dotnet build --configuration Release")]
    [InlineData(3, $"dotnet test")]
    [InlineData(4, $"dotnet publish -c Release")]
    public override void TestScriptContent(
        int index
        , string expected)
    {
        var moq = new Mock<IScriptParam>();
        SetupParams(moq);
        IScript script = new CompileScript(moq.Object);

        var acctual = GetLine(script, index);

        Assert.Equal(expected, acctual);
    }
}