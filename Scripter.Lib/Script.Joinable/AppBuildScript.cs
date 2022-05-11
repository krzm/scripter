namespace Scripter;

public class AppBuildScript
    : BuildScript
{
    public AppBuildScript(IScriptParam scriptParam)
        : base(scriptParam)
    {
    }

    public override string[] GetScript()
    {
        return new string[]
        {
            $"& \"$PSScriptRoot\\{ProjName}.Clone.ps1\""
            , $"& \"$PSScriptRoot\\{ProjName}.Pull.ps1\""
            , $"& \"$PSScriptRoot\\{ProjName}.Compile.ps1\""
            , $"& \"$PSScriptRoot\\{ProjName}.Version.ps1\""
            , $"& \"$PSScriptRoot\\{ProjName}.Copy.ps1\""
            , $"& \"$PSScriptRoot\\{ProjName}.CopyApp.ps1\""
        };
    }
}