using System.ComponentModel;

namespace Calculator.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string Propertyname)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(Propertyname));
        }
    }
}
