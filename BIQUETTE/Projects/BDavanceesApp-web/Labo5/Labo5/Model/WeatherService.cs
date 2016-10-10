using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Labo5.Model
{
    public class WeatherService
    {
        public async Task<IEnumerable<WeatherForecast>> GetForecast()
        {
                //(1) creation obj HttpCLient
            var wc = new HttpClient();


                //(2)requete Get (recup données sous forme Json)
                // await car requete peut prendre du tps
            var weather = await wc.GetStringAsync(new Uri("http://api.openweathermap.org/data/2.5/forecast/city?q=Namur,fr&mode=xml&APPID=6e613b9aa651996dab54a5fdf5a5b309"));
               

                //Parse resultat et extraire element
            var rawWeather = JObject.Parse(weather);


            var forecast = rawWeather["list"].Children().Select(d => new WeatherForecast()
            {
                Date = d["dt_txt"].Value<DateTime>(),
                MinTemp = d["main"]["temp_min"].Value<double>(),
                MaxTemp = d["main"]["temp_max"].Value<double>(),
                WingSpeed = d["wind"]["speed"].Value<double>(),
                WeatherDescription = d["weather"].First["description"].Value<string>()
            });

            return forecast;
        }

    }
}
