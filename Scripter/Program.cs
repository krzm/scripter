using DIHelper.Bootstraper;
using Unity;

namespace Scripter;

public class Program
{
	static void Main(string[] args)
	{
        IBootstraper booter = new Bootstraper(
			new UnityDependencySuite(
				new UnityContainer().AddExtension(
                    new Diagnostic())));
		booter.Boot(args);
	}
}