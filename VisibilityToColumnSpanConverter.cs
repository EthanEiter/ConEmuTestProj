using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ConEmuTestProj
{

    [ValueConversion(typeof(Visibility), typeof(int))]
    public class VisibilityToColumnSpanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (Visibility)value == Visibility.Collapsed ? 2 : 1;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => null;
    }
}
