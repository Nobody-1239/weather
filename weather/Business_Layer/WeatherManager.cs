using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Model;
using Newtonsoft.Json.Linq;


namespace Business_Layer
{
    public class WeatherManager
    {
        public string Weather_Description { get; set; }
        public string temperature { get; set; }
        public string Wind { get; set; }

        private static readonly HttpClient _httpClient = new HttpClient();
        private static JObject _weather;
        public async Task Connection(string city_name)
        {

            WeatherInfo weather = new WeatherInfo
            {
                CityName = city_name,
                ApiKey = "6fcf773d7841ab5bee10b62867f318ec",
            };
            weather.URL = $"http://api.openweathermap.org/data/2.5/weather?q={weather.CityName}&appid={weather.ApiKey}&units=metric".ToString();

            try
            {
                var response = await _httpClient.GetAsync(weather.URL);
                var content = await response.Content.ReadAsStringAsync();
                _weather = JObject.Parse(content);
            }
            catch
            {

            }
        }
        public void ExtracData()
        {
            if (_weather != null)
            {
                string WeatherDescription = _weather["weather"][0]["description"].ToString();
                double temp = (double)_weather["main"]["temp"];
                double wind = (double)_weather["wind"]["speed"];

                Weather_Description = WeatherDescription;
                temperature = Convert.ToString(temp);
                Wind = Convert.ToString(wind);
            }
            else
            {

            }
        }
    }
}
