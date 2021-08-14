using System;
using System.Globalization;
using System.Windows.Data;

namespace Calculator
{
    class PopupConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value == true)
            {
                return false;
            }
            else
            {
                return true;

            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return "x*x^9";
        }
    }
}
