using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace _001_ARGB
{
    public class DoubleToColorConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return Color.FromArgb((byte)(double)values[0], (byte)(double)values[1], (byte)(double)values[2], (byte)(double)values[3]);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            Color C = (Color)value;
            return new object[] { (double)C.ScA, (double)C.ScR, (double)C.ScG, (double)C.ScB };
        }
    }
}
