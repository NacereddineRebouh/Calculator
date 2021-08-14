using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace Calculator.userControls
{
    /// <summary>
    /// Interaction logic for SideMenuControl.xaml
    /// </summary>
    public partial class SideMenuControl : UserControl
    {
        //converter :convert width to bool
        public SideMenuControl()
        {

            InitializeComponent();


        }



        public ICommand updateViewCommand
        {
            get { return (ICommand)GetValue(updateViewCommandProperty); }
            set { SetValue(updateViewCommandProperty, value); }
        }
        public static readonly DependencyProperty updateViewCommandProperty =
            DependencyProperty.Register("updateViewCommand", typeof(ICommand), typeof(SideMenuControl), null);



        public double SetWidth
        {
            get { return (double)GetValue(SetWidthProperty); }
            set { SetValue(SetWidthProperty, value); }
        }


        public static readonly DependencyProperty SetWidthProperty =
            DependencyProperty.Register("SetWidth", typeof(double), typeof(SideMenuControl), new PropertyMetadata(0.0));



        private void Button_Click(object sender, RoutedEventArgs e)
        {

            ShortenObject(0, TimeSpan.FromSeconds(0.1));

        }


        private void ShortenObject(int newWidth, TimeSpan duration)
        {
            //MinWidth = 0;

            DoubleAnimation animation = new DoubleAnimation(newWidth, duration);
            MyuserControl.BeginAnimation(UserControl.WidthProperty, animation);




        }

        private void Close_SideMenu(object sender, RoutedEventArgs e)
        {
            ShortenObject(0, TimeSpan.FromSeconds(0.1));
        }
    }
}
