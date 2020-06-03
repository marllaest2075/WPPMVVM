﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ViewModels.Converters
{
    [ValueConversion(typeof(double), typeof(double))]
    public class HeightToFontSizeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // here you can use the parameter that you can give in here via setting , ConverterParameter='something'} or use any nice login with the VisualTreeHelper to make a better return value, or maybe even just hardcode some max values if you like
            var height = (double)value;
            return .3 * height;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}