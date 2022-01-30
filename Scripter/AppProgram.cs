using CommandDotNet;
using CommandDotNet.Repl;
using System.Diagnostics.CodeAnalysis;
using Unity;

namespace Scripter;

public class AppProgram 
    : CommandDotNet.Helper.AppProgramUnity<AppProgram>
{
    private static bool inSession;

    [Subcommand]
    public ScriptCommands? ScriptCommands { get; set; }

    public AppProgram(
        IUnityContainer container)
            : base(container)
    {
    }

    [DefaultCommand()]
    [SuppressMessage(
        "Performance"
        , "CA1822:Mark members as static"
        , Justification = "CommandDotNet needs instance member")]
    public void StartSession(
        CommandContext context
        , ReplSession replSession)
    {
        if (inSession == false)
        {
            context.Console.WriteLine("start session");
            inSession = true;
            replSession.Start();
        }
        else
        {
            context.Console.WriteLine($"no session {inSession}");
            context.ShowHelpOnExit = true;
        }
    }

    protected override void RegisterCommandClasses(AppRunner appRunner)
    {
        var commandClassTypes = appRunner.GetCommandClassTypes();
        var registeredExplicitly = new Type[]
        {
        };
        foreach (var type in commandClassTypes)
        {
            if (registeredExplicitly.Contains(type.type)) continue;
            Container.RegisterSingleton(type.type);
        }
    }
}