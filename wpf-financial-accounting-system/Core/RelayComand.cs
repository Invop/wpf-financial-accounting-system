namespace wpf_financial_accounting_system.Core;

using System;
using System.Windows.Input;

public class RelayCommand : ICommand
{
    private Action<object> execute;
    private Predicate<object> canExecute;

    public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
    {
        this.execute = execute ?? throw new ArgumentNullException("execute");
        this.canExecute = canExecute;
    }

    public bool CanExecute(object parameter)
    {
        return canExecute == null || canExecute(parameter);
    }

    public event EventHandler CanExecuteChanged
    {
        add { CommandManager.RequerySuggested += value; }
        remove { CommandManager.RequerySuggested -= value; }
    }

    public void Execute(object parameter)
    {
        execute(parameter);
    }
}
