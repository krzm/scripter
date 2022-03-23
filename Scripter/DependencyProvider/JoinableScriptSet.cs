using DIHelper.Unity;
using Unity;

namespace Scripter;

public class JoinableScriptSet
    : UnityDependencySet
{
    public JoinableScriptSet(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void Register()
    {
        Container.RegisterSingleton<IScriptParam, ScriptParam>();

        Container.RegisterSingleton<IScript, CompileScript>(nameof(CompileScript));
        Container.RegisterSingleton<IScript, VersionScript>(nameof(VersionScript));
        Container.RegisterSingleton<IScript, CopyScript>(nameof(CopyScript));
        Container.RegisterSingleton<IScript, CopyAppScript>(nameof(CopyAppScript));
        Container.RegisterSingleton<IScript, BuildScript>(nameof(BuildScript));
    }
}