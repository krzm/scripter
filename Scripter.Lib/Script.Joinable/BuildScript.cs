namespace Scripter;

public class BuildScript : IScript
{
    private readonly IScriptParam scriptParam;

    public string File => $"{scriptParam.Project.ProjFolder}.Build.ps1";

    public BuildScript(IScriptParam scriptParam)
    {
        this.scriptParam = scriptParam;
    }

    public string[] GetScript()
    {
        var scriptName = scriptParam.Project.ProjFolder;
        return new string[]
        {
            $"& \"$PSScriptRoot\\{scriptName}.Compile.ps1\""
            , $"& \"$PSScriptRoot\\{scriptName}.Version.ps1\""
            , $"& \"$PSScriptRoot\\{scriptName}.Copy.ps1\""
        };
    }
}