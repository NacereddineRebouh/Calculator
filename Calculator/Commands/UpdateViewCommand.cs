using Calculator.ViewModels;
using System;
using System.Windows.Input;

namespace SwitchViewMVVM.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private MainViewModel viewmodel;
        public UpdateViewCommand(MainViewModel viewmodel)
        {
            this.viewmodel = viewmodel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Console.WriteLine("here");

            if (parameter.ToString() == "Standard")
            {
                viewmodel.SelectedView = new StandardViewModel();
            }
            else
            {
                viewmodel.SelectedView = new ScientificViewModel();
            }
        }
    }
}
