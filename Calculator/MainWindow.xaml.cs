using System.Windows;
using System.Windows.Controls;

namespace Calculator
{


    public partial class MainWindow : Window
    {



        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            string Test = "mew";
            bool Max = true;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            meow2.Content = "f";
            Button srcButton = e.Source as Button;
            _ = MessageBox.Show(srcButton.Name);
            switch (srcButton.Name)
            {
                case "Min":
                    // Minimize Window
                    meow2.Content = "1";
                    WindowState = WindowState.Minimized;
                    break;

                case "Full":
                    // FullSize/OriginalSize Window

                    if (WindowState == WindowState.Maximized)
                    {
                        meow2.Content = "2";
                        MainWindow.Max = false;
                        //srcButton.FindName("image22") = new BitmapImage(new Uri("yor image uri"));
                        WindowState = WindowState.Normal;


                    }
                    else
                    {
                        meow2.Content = "3";
                        Max = true;
                        WindowState = WindowState.Maximized;


                    }

                    break;

                case "Exit":
                    // Exit
                    Close();
                    break;
                default:
                    break;
            }


        }


        //style buttons
    }
}
