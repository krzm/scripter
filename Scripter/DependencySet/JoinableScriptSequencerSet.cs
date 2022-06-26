using DIHelper.Unity;
using Scripter.Lib;
using Unity;

namespace Scripter;

public class JoinableScriptSequencerSet 
	: UnityDependencySet
{
	public JoinableScriptSequencerSet(
		IUnityContainer container) 
		: base(container)
	{
	}

	public override void Register()
	{
		RegisterValidator<DefaultProjScriptSequence>(
			ProjectTypes.Default);
        RegisterValidator<AppProjScriptSequence>(
			ProjectTypes.App);
        RegisterValidator<WpfProjScriptSequence>(
			ProjectTypes.Wpf);
        RegisterValidator<WpfProjScriptSequence>(
			ProjectTypes.WpfApp);
	}

    private void RegisterValidator<TSequencer>(
		ProjectTypes sequencer)
		where TSequencer : IJoinableScriptSequencer
	{
		Container.RegisterSingleton<IJoinableScriptSequencer, TSequencer>(
			sequencer.ToString());
	}
}