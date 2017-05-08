using System;
using System.Globalization;
using System.Windows.Data;

namespace WPF_Peliculas
{
    [ValueConversion(typeof(double), typeof(string))]
    class ConversorCalificacion : IValueConverter
    {
        string[] valoresALetras = {"Cero", "Uno", "Dos", "Tres", "Cuatro", "Cinco" };

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Convierte el valor entero a letras:
            if (targetType == typeof(string) && value.GetType() == typeof(double))
            {
                return valoresALetras[(int)Math.Round((double)value)];
            }
            else
                return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
