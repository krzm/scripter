namespace Scripter.Lib;

public class AppProjScriptSequence
    : JoinableScriptSequencerBase
{
    public override JoinableScripts[] GetProjScriptSequence()
    {
        return new JoinableScripts[]
        {
            JoinableScripts.Clone
            , JoinableScripts.Pull
            , JoinableScripts.Compile
            , JoinableScripts.CopyBuild
            , JoinableScripts.CopyApp
            , JoinableScripts.VersionFile
            , JoinableScripts.BuildApp
        };
    }
}