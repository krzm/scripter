using System.Text;

namespace Scripter;

public class VersionScript : IVersionScript
{
    private readonly IScriptVariables scriptVariables;

    public VersionScript(IScriptVariables scriptVariables)
    {
        this.scriptVariables = scriptVariables;
    }

    public string GetScript()
    {
        var sb = new StringBuilder();
        sb.Append($"$scriptPath = {scriptVariables.ScriptPath}\\r\\n");
        sb.Append($"$appsPath = {scriptVariables.BuildPath}\\r\\n");
        sb.Append($"$repoPath = {scriptVariables.RepoPath}\\r\\n");

        return sb.ToString();
    }
}