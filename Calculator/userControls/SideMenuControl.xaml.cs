using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Calculator.userControls
{
    /// <summary>
    /// Interaction logic for SideMenuControl.xaml
    /// </summary>
    public partial class SideMenuControl : UserControl
    {

        public SideMenuControl()
        {
            InitializeComponent();


        }

        //public int SetWidth
        //{
        //    get { return (int)GetValue(SetWidthProperty); }
        //    set { SetValue(SetWidthProperty, value); }
        //}

        //public static readonly DependencyProperty SetWidthProperty =
        //   DependencyProperty.Register(nameof(SetWidth), typeof(int), typeof(SideMenuControl), new PropertyMetadata(0));


        public double SetHeight
        {
            get { return (double)GetValue(SetHeightProperty); }
            set { SetValue(SetHeightProperty, value); }
        }



        public static readonly DependencyProperty SetHeightProperty =
            DependencyProperty.Register("SetHeight", typeof(double), typeof(SideMenuControl), new PropertyMetadata(0.0));


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button srcButton = e.Source as Button;
            //MessageBox.Show(srcButton.Name);
            //this.Width = 0;
            WidenObject(0, TimeSpan.FromSeconds(0.2));
            //CloseMenu.Visibility = Visibility.Collapsed;

        }

        private void WidenObject(int newWidth, TimeSpan duration)
        {
            DoubleAnimation animation = new DoubleAnimation(newWidth, duration);
            this.BeginAnimation(UserControl.WidthProperty, animation);
        }
    }
}
