using Moq;
using Xunit;

namespace Scripter.Lib.Tests;

public class CompileScriptTests : ScriptTests
{
    [Theory]
    [InlineData(
        0
        , $"Set-Location -Path \"C:\\kmazanek@gmail.com\\Code\\Log.Modern.ConsoleApp\""
        )]
    [InlineData(
        1
        , $"dotnet build"
        )]
    [InlineData(
        2
        , $"dotnet publish -c Release"
        )]
    [InlineData(
        3
        , $"dotnet build --configuration Release"
        )]
    [InlineData(
        4
        , $"dotnet test"
        )]
    public void TestCorrectnessOfScript(
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