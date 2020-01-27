using System;
using System.Globalization;
using Xamarin.Forms;

namespace Blauhaus.Forms.Controls.Core.Converters
{
    public class StringNotNullOrEmptyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var stringValue = (string) value;
            var returnValue = string.IsNullOrEmpty(stringValue) 
                ? "--empty--" 
                : stringValue;
            return returnValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}