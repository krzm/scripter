﻿namespace Scripter;

public class CompileScript : IScript
{
    private readonly IScriptParam scriptParam;

    public string File => $"{scriptParam.Project.RepoFolder}.Compile.ps1";

    public CompileScript(IScriptParam scriptParam)
    {
        this.scriptParam = scriptParam;
    }

    public string[] GetScript()
    {
        return new string[]
        {
            $"Set-Location -Path \"{scriptParam.RepoPath}\""
            , $"dotnet build"
            , $"dotnet build --configuration Release"
            , $"dotnet test"
            , $"dotnet publish -c Release"
        };
    }
}