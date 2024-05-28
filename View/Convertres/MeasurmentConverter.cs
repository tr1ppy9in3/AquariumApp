﻿using System.Globalization;
using System.Windows.Data;
using ViewModel.Abstractions;

namespace View.Convertres
{
    public class MeasurmentConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || parameter == null || !Enum.TryParse(parameter.ToString(), out DataType dataType)) return null;

            switch (dataType)
            {
                case DataType.Temperature:
                    return $"{value} °C";
                case DataType.OxygenLevel:
                    return $"{value} ppm";
                case DataType.LigthingLevel:
                    return $"{value} лк";
                case DataType.AcidityLevel:
                    return $"{value} pH";
                case DataType.SalinityLevel:
                    return $"{value} мг/л";
                case DataType.Length:
                case DataType.Width:
                    return $"{value} см.";
                case DataType.Quantity:
                    return $"{value} шт.";
                default:
                    return value.ToString();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
