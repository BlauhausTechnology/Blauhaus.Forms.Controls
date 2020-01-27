using System;
using System.Globalization;
using Xamarin.Forms;

namespace Blauhaus.Forms.Controls.Core.Converters
{
    public class StringNotEmptyToBoolConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var stringValue = (string) value;
            return !string.IsNullOrEmpty(stringValue);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var stringValue = (string) value;
            return !string.IsNullOrEmpty(stringValue);
        }
    }
}