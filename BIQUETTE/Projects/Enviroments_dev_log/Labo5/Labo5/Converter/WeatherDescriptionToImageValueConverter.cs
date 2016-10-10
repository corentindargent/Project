using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Imaging;


namespace Labo5.Converter
{
    class WeatherDescriptionToImageValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var forecast = (string)value;
            if (forecast.Contains("nuageux"))
                return new BitmapImage(new Uri("ms-appx:/Images/images.png"));
            else
            if (forecast.Contains("pluies"))
                return new BitmapImage(new Uri("ms-appx:/Images/cloud.jpg"));
            else                
            return new BitmapImage(new Uri("ms-appx:/Images/search.jpg"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
