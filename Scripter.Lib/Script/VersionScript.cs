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
        sb.Append($"$scriptFolder = {scriptVariables.ScriptPath}\\r\\n");
        return sb.ToString();
    }
}