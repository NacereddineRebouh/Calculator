using SwitchViewMVVM.Commands;
using System.Windows.Input;

namespace Calculator.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel _selectedView;

        public BaseViewModel SelectedView
        {
            get { return _selectedView; }
            set
            {
                _selectedView = value;
                OnPropertyChanged(nameof(SelectedView));
            }
        }
        public ICommand UpdateViewCommand { get; set; }

        public MainViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
        }


    }
}
