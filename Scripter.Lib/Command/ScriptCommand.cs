using System.Windows.Input;

namespace Scripter.Lib;

public class ScriptCommand : ICommand
{
    private readonly IScriptParam scriptParam;
    private readonly List<IScript> scripts;

    public event EventHandler? CanExecuteChanged;

    public ScriptCommand(
        IScriptParam scriptParam
        , List<IScript> scripts)
    {
        this.scriptParam = scriptParam;
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
            scriptParam.ProjectName = project;
            foreach (var script in scripts)
            {
                var filePath = Path.Combine(scriptParam.ScriptPath, script.File);
                File.WriteAllLines(filePath, script.GetScript());
            }
        }
    }
}