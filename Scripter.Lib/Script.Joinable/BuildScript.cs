namespace Scripter;

public class BuildScript : IScript
{
    private readonly IScriptParam scriptParam;

    public string File
    {
        get
        {
            ArgumentNullException.ThrowIfNull(scriptParam.Project);
            return $"{scriptParam.Project.ProjFolder}.Build.ps1";
        }
    }

    public BuildScript(IScriptParam scriptParam)
    {
        this.scriptParam = scriptParam;
        ArgumentNullException.ThrowIfNull(this.scriptParam);
    }

    public string[] GetScript()
    {
        ArgumentNullException.ThrowIfNull(scriptParam.Project);
        var name = scriptParam.Project.ProjFolder;
        var list = new List<string>
        {
             $"& \"$PSScriptRoot\\{name}.Compile.ps1\""
            , $"& \"$PSScriptRoot\\{name}.Version.ps1\""
            , $"& \"$PSScriptRoot\\{name}.Copy.ps1\""
        };
        if(scriptParam.Project.IsApp)
            list.Add($"& \"$PSScriptRoot\\{name}.CopyApp.ps1\"");
        return list.ToArray();
    }
}