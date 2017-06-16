using System;
using System.Windows.Input;

namespace Beer.Commands
{
    public class SignInCommand : ICommand
    {

        public BaseViewModel ViewModel { get; set; }

        public SignInCommand(BaseViewModel viewModel)
        {
            ViewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
