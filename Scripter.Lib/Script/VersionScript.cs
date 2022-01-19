namespace Scripter;

public class VersionScript : IVersionScript
{
    private readonly IScriptVariables scriptVariables;

    public VersionScript(IScriptVariables scriptVariables)
    {
        this.scriptVariables = scriptVariables;
    }

    public string[] GetScript()
    {
        return new string[]
        {
            $"$projectName = \"{scriptVariables.ProjectName}\"{Environment.NewLine}"
            , $"$versionFileName = \"{scriptVariables.VersionFileName}\"{Environment.NewLine}"
            , $"$buildPath = \"{scriptVariables.BuildPath}\"{Environment.NewLine}"
        };
    }
}