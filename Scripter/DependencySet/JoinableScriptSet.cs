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

        RegisterScript<CloneScript>();
        RegisterScript<PullScript>();
        RegisterScript<CompileScript>();
        RegisterScript<VersionScript>();
        RegisterScript<CopyBuildScript>();
        RegisterScript<CopyBuildWpfScript>();
        RegisterScript<CopyAppScript>();
        RegisterScript<BuildScript>();
    }

    private void RegisterScript<TData>()
        where TData : IScript
    {
        Container
            .RegisterSingleton<IScript, TData>(
                typeof(TData).Name);
    }
}