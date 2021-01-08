using System;
using System.Diagnostics;
using System.Windows.Input;

namespace MVVM_Lib.ViewModel
{
    class ModelCommand : ICommand
    {
        private Action<object> execute;
        private Predicate<object> canExecute;

        public ModelCommand(Action<object> execute) : this(execute, null) { }
        public ModelCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            return canExecute == null ? true : canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
    }
}
