using System.Windows;

namespace Calculator
{
    class ButtonRessource : ResourceDictionary
    {
        public ButtonRessource()
        {
            InitializeComponent();
        }
        private void Exit_Clicked(object sender, MouseEventArgs e)
        {
            ;
        }
        private void Full_Clicked(object sender, MouseEventArgs e)
        {
            Close();
        }
        private void Min_Clicked(object sender, MouseEventArgs e)
        {
            Close();
        }
    }
