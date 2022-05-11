using DIHelper.Unity;
using Scripter.Lib;
using Unity;

namespace Scripter;

public class ProjDataValidatorDictionarySet 
	: UnityDependencySet
{
	public ProjDataValidatorDictionarySet(
		IUnityContainer container) 
		: base(container)
	{
	}

	public override void Register()
	{
		Container.RegisterFactory<IDictionary<ProjDataValidators, IProjDataValidator>>(
			c => FillDictionary(
                new Dictionary<ProjDataValidators, IProjDataValidator>()));
	}

    private IDictionary<ProjDataValidators, IProjDataValidator> FillDictionary(
        IDictionary<ProjDataValidators, IProjDataValidator> store)
    {
		if(store.Count > 0) 
			return store;
		Add(store, ProjDataValidators.Default);
		Add(store, ProjDataValidators.App);
		Add(store, ProjDataValidators.Wpf);
		Add(store, ProjDataValidators.WpfApp);
		return store;
    }

	private void Add(
        IDictionary<ProjDataValidators, IProjDataValidator> store
		, ProjDataValidators validator)
	{
        store.Add(validator, ResolveScript(validator));
	}

    private IProjDataValidator ResolveScript(ProjDataValidators validator)
	{
		return Container.Resolve<IProjDataValidator>(
			validator.ToString());
	}
}