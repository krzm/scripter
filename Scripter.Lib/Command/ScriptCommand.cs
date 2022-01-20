using System.Windows.Input;

namespace Scripter.Lib;

public class ScriptCommand : ICommand
{
    private readonly IScriptVariables scriptVariables;
    private readonly List<IScript> scripts;

    public event EventHandler? CanExecuteChanged;

    public ScriptCommand(
        IScriptVariables scriptVariables
        , List<IScript> scripts)
    {
        this.scriptVariables = scriptVariables;
        this.scripts = scripts;
    }

    public bool CanExecute(object? parameter) => true;

    public void Execute(object? parameter)
    {
        var projects = new string[]
        {
            "Log.Modern.ConsoleApp"
        };
        for (int i = 0; i < projects.Length; i++)
        {
            scriptVariables.ProjectName = projects[i];
            var script = scripts[i].GetScript();
            var filePath = Path.Combine(scriptVariables.ScriptPath, scripts[i].File);
            File.WriteAllLines(filePath, script);
        }
    }
}