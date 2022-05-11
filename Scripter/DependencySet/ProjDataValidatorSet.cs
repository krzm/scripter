using DIHelper.Unity;
using Scripter.Lib;
using Unity;

namespace Scripter;

public class ProjDataValidatorSet 
	: UnityDependencySet
{
	public ProjDataValidatorSet(
		IUnityContainer container) 
		: base(container)
	{
	}

	public override void Register()
	{
		RegisterValidator<DefaultProjValidator>(
			ProjDataValidators.Default);
        RegisterValidator<AppProjValidator>(
			ProjDataValidators.App);
        RegisterValidator<WpfProjValidator>(
			ProjDataValidators.Wpf);
        RegisterValidator<WpfAppProjValidator>(
			ProjDataValidators.WpfApp);
	}

    private void RegisterValidator<TValidator>(
		ProjDataValidators validator)
		where TValidator : IProjDataValidator
	{
		Container.RegisterSingleton<IProjDataValidator, TValidator>(
			validator.ToString());
	}
}