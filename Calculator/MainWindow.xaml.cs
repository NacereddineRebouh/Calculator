using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Calculator
{


    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //-----------Access window.xaml template's elements-----------//


            ControlTemplate i = Full.Template;
            Image image = i.FindName("btn_Image", Full) as Image;


            string max = "/images/Maximize.png";
            string min = "/images/Minimize.png";

            //-----------------------------------------------------------//

            Button srcButton = e.Source as Button;
            switch (srcButton.Name)
            {
                case "Min":
                    // Minimize Window

                    WindowState = WindowState.Minimized;
                    break;

                case "Full":
                    // FullSize/OriginalSize Window

                    if (WindowState == WindowState.Maximized)
                    {

                        image.Source = new BitmapImage(new Uri(max, UriKind.RelativeOrAbsolute));
                        //srcButton.FindName("image22") = new BitmapImage(new Uri("yor image uri"));
                        WindowState = WindowState.Normal;
                    }
                    else
                    {

                        image.Source = new BitmapImage(new Uri(min, UriKind.RelativeOrAbsolute));
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

        private void WindowDrag(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //MessageBox.Show("meow");
            this.DragMove();
        }


        //style buttons
    }
}
