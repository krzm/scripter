namespace Scripter;

public class WpfProjCopyScript
    : CopyScript
{
    public WpfProjCopyScript(
        IScriptParam scriptParam) 
            : base(scriptParam)
    {
    }

    protected override string GetNetVer() => "net6.0-windows";
}