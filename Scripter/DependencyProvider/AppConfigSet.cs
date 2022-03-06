using DIHelper.Unity;
using Microsoft.Extensions.Configuration;
using Unity;

namespace Scripter;

public class AppConfigSet 
    : UnityDependencySet
{
    public AppConfigSet(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void Register()
    {
        IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional:true)
            .AddEnvironmentVariables()
            .Build();
        Container.RegisterInstance<IConfiguration>(config);
    }
}