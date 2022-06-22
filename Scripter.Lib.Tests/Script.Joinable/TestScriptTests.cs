using Xunit;

namespace Scripter.Lib.Tests;

// public class TestScriptTests 
//     : ScriptTest
// {
//     [Theory]
//     [InlineData(0, $"Set-Location -Path \"C:\\kmazanek@gmail.com\\Code\\cli-helper\"")]
//     [InlineData(1, $"dotnet test")]
//     [InlineData(2, $"Set-Location -Path \"C:\\kmazanek@gmail.com\\Build.Script\"")]
//     public override void TestScriptContent(
//         int index
//         , string expected)
//     {
//         var moq = SetupParamsMock(new ParamsMockData());
//         IScript script = new TestScript(moq.Object);

//         var acctual = GetLine(script, index);

//         Assert.Equal(expected, acctual);
//     }
// }