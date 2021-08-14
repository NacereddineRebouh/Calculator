using Calculator.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace Calculator
{


    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            DataContext = new MainViewModel();
            InitializeComponent();
            Left = 400;
            Top = 100;
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
                        //WindowState = WindowState.Maximized;

                        MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight - 10;
                        MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth - 10;

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

        //private void WindowDrag(object sender, MouseButtonEventArgs e)
        //{
        //    ControlTemplate i = Full.Template;
        //    Image image = i.FindName("btn_Image", Full) as Image;


        //    string max = "/images/Maximize.png";
        //    string min = "/images/Minimize.png";

        //    if (WindowState == WindowState.Normal)
        //    {
        //        this.DragMove();
        //    }
        //    else
        //    {
        //        image.Source = new BitmapImage(new Uri(max, UriKind.RelativeOrAbsolute));
        //        //WindowState = WindowState.Maximized;
        //        WindowState = WindowState.Normal;
        //        MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight - 30;
        //        MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth - 30;
        //        Left = 10; Top = 10;



        //    }
        //}

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ControlTemplate i = Full.Template;
            Image image = i.FindName("btn_Image", Full) as Image;


            string max = "/images/Maximize.png";
            string min = "/images/Minimize.png";

            if (e.ClickCount == 2)
            {
                if (WindowState == WindowState.Maximized)
                {

                    image.Source = new BitmapImage(new Uri(max, UriKind.RelativeOrAbsolute));
                    //srcButton.FindName("image22") = new BitmapImage(new Uri("yor image uri"));
                    WindowState = WindowState.Normal;
                }
                else
                {

                    image.Source = new BitmapImage(new Uri(min, UriKind.RelativeOrAbsolute));
                    //WindowState = WindowState.Maximized;

                    MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight - 10;
                    MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth - 10;

                    WindowState = WindowState.Maximized;

                }




            }
            else if (e.ClickCount == 1)
            {
                if (WindowState == WindowState.Normal)
                {
                    this.DragMove();
                }
                else
                {

                    image.Source = new BitmapImage(new Uri(max, UriKind.RelativeOrAbsolute));
                    //WindowState = WindowState.Maximized;
                    WindowState = WindowState.Normal;
                    MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight - 10;
                    MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth - 10;
                    Point p = e.GetPosition(this);
                    double x = p.X;
                    double y = p.Y;
                    Left = x - 100;
                    Top = y - 20;
                    try { this.DragMove(); } catch { }

                }

            }
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (ActualHeight >= 774 && ActualWidth >= 1310)
            {
                ControlTemplate i = Full.Template;
                Image image = i.FindName("btn_Image", Full) as Image;


                string min = "/images/Minimize.png";
                image.Source = new BitmapImage(new Uri(min, UriKind.RelativeOrAbsolute));

            }


            //Change side menu size//
            if (ActualHeight > 0)
            {

                SideMenu.Width = ActualWidth;
                SideMenu.Height = ActualHeight - 30;
                //StandardPage.Height = 62.5 * ActualHeight / 100;
                //StandardPage.Width = ActualWidth;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //SideMenu.Width = 260;
            SideMenu.Focus();
            WidenObject(260, TimeSpan.FromSeconds(0.3));
        }


        private void WidenObject(int newWidth, TimeSpan duration)
        {
            DoubleAnimation animation = new DoubleAnimation(newWidth, duration);
            QuarticEase e = new QuarticEase();
            e.EasingMode = EasingMode.EaseOut;
            animation.EasingFunction = e;
            SideMenu.BeginAnimation(UserControl.WidthProperty, animation);
        }


    }
}
