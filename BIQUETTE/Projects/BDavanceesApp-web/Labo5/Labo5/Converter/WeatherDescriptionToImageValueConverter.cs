using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;


namespace Labo5.Converter
{
    class WeatherDescriptionToImageValueConverter : IvalueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var forecast = (string)value;
            if (forecast.Contains("cloud"))
                return new BitmapImage(new Uri("ms-appx/Images/imgres.jpg"));
            else
                return  new BitmapImage(new Uri("ms-appx/Images/sunny.jpg"));

        }

        public object ConverterBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
