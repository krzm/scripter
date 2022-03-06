using CommandDotNet;
using CommandDotNet.Repl;
using CommandDotNet.Unity.Helper;

namespace Scripter;

public class AppProg 
    : AppProgUnity<AppProg>
{
    private static bool inSession;

    [Subcommand]
    public ScriptCommands? ScriptCommands { get; set; }

    [DefaultCommand()]
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
}