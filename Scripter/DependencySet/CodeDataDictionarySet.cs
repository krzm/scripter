using DIHelper.Unity;
using Scripter.Data;
using Scripter.Data.Helper;
using Unity;

namespace Scripter;

public class CodeDataDictionarySet 
	: UnityDependencySet
{
	public CodeDataDictionarySet(
		IUnityContainer container) 
		: base(container)
	{
	}

	public override void Register()
	{
		Container.RegisterFactory<IDictionary<string, ICodeData>>(
			c => FillDictionary(
                new Dictionary<string, ICodeData>()));
	}

    private IDictionary<string, ICodeData> FillDictionary(
        IDictionary<string, ICodeData> store)
    {
		if(store.Count > 0) 
			return store;
		Add(store, nameof(ManyRefLibData));
		Add(store, nameof(TestAppsData));
		Add(store, nameof(WrapperAppsData));
		Add(store, nameof(SampleAppsData));
		Add(store, nameof(SmallAppsData));
		Add(store, nameof(ScripterData));
		Add(store, nameof(CliAppTemplateData));
		Add(store, nameof(AppStarterData));
		Add(store, nameof(CommanderData));
		Add(store, nameof(MicroservicesData));
		Add(store, nameof(DiyBoxData));
		Add(store, nameof(GameData));
		Add(store, nameof(ModernLogData));
		Add(store, nameof(ModernMDILogData));
		Add(store, nameof(ModernWizardLogData));
		Add(store, nameof(ConsoleLogData));
		Add(store, nameof(ModernInventoryAppData));
		Add(store, nameof(MyCliLibInventoryAppData));
		Add(store, nameof(ShapeEngineData));
		return store;
    }

	private void Add(
        IDictionary<string, ICodeData> store
		, string key)
	{
        store.Add(key, ResolveScript(key));
	}

    private ICodeData ResolveScript(string key)
	{
		return Container.Resolve<ICodeData>(
			key.ToString());
	}
}