using System.Windows.Input;

namespace Scripter;

public class ScriptCommand : ICommand
{
    public event EventHandler? CanExecuteChanged;

    public bool CanExecute(object? parameter) => true;

    public void Execute(object? parameter)
    {
    
    }
}