using System.Windows.Input;

namespace Scripter.Lib;

public class ScriptCommand : ICommand
{
    private readonly IScriptParam scriptVariables;
    private readonly List<IScript> scripts;

    public event EventHandler? CanExecuteChanged;

    public ScriptCommand(
        IScriptParam scriptVariables
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
        foreach (var project in projects)
        {
            scriptVariables.ProjectName = project;
            foreach (var script in scripts)
            {
                var filePath = Path.Combine(scriptVariables.ScriptPath, script.File);
                File.WriteAllLines(filePath, script.GetScript());
            }
        }
    }
}