namespace Scripter;

public class CompileScript : IScript
{
    private readonly IScriptVariables scriptVariables;

    public string File => "Compile.ps1";

    public CompileScript(IScriptVariables scriptVariables)
    {
        this.scriptVariables = scriptVariables;
    }

    public string[] GetScript()
    {
        return new string[]
        {
            $"Set-Location -Path \"{scriptVariables.RepoPath}\""
            , $"dotnet build"
            , $"dotnet publish -c Release"
            , $"dotnet build --configuration Release"
        };
    }
}