using System.ComponentModel;

namespace Calculator.userControls.INotify
{
    class INotifyHeightChanged : INotifyPropertyChanged
    {

        private double height;

        public INotifyHeightChanged(double height)
        {
            this.height = height;
            SD = height;
        }

        public double SD
        {
            get { return height; }
            set
            {
                if (height != value)
                {
                    height = value;
                    OnPropertyChanged("Height");
                }
            }
        }

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                //Raising Event
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
