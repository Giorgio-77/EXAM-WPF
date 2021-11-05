using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _001_ARGB.Infrastructure
{
    class RelayCommand : ICommand
    {
        Action<object> _execute;
        Predicate<object> _canExecute;

        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            _execute?.Invoke(parameter);
        }
    }
}
