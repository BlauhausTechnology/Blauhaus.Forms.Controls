using System;
using System.Globalization;
using Xamarin.Forms;

namespace Blauhaus.Forms.Controls.Core.Converters
{
    public class BoolToColorConverter : IValueConverter
    {
        private readonly Color _trueColour;
        private readonly Color _falseColour;

        public BoolToColorConverter(Color trueColour, Color falseColour)
        {
            _trueColour = trueColour;
            _falseColour = falseColour;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var isTrue = (bool) value;
            return isTrue ? _trueColour : _falseColour;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var color = (Color) value;
            return color == _trueColour;
        }
    }
}