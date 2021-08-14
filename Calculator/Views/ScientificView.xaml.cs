using System.ComponentModel;
using System.Windows.Controls;

namespace Calculator.View
{
    /// <summary>
    /// Interaction logic for SientificView.xaml
    /// </summary>
    public partial class ScientificView : UserControl, INotifyPropertyChanged
    {
        private bool open = true;
        public event PropertyChangedEventHandler PropertyChanged;

        public bool Open
        {
            get { return open; }
            set
            {
                open = value;
                OnPropertyChanged(nameof(Open));
            }
        }

        public ScientificView()
        {
            InitializeComponent();
        }

        public void OnPropertyChanged(string Propertyname)
        {

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(Propertyname));
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //change button


            //implement inotify to notify the view that this var is chnaged
        }



    }
}
