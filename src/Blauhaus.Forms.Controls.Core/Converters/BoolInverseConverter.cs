﻿using System;
using System.Globalization;
using Xamarin.Forms;

namespace Blauhaus.Forms.Controls.Core.Converters
{
    public class BoolInverseConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !(bool) value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !(bool) value;
        }
    }
}