using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        public static void GetWeather()
        {
            var client = new HttpClient();
            Console.WriteLine("Input your API Key:");
            var key = Console.ReadLine();
            Console.Write("Enter your ZIP code: ");
            var zipCode = Console.ReadLine();
            var weatherAPI = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={key}";
            var weatherInfo = client.GetStringAsync(weatherAPI).Result;
            var city = JObject.Parse(weatherInfo)["name"].ToString();
            var temp = JObject.Parse(weatherInfo)["main"]["temp"].ToString();
            var feelsLike = JObject.Parse(weatherInfo)["main"]["feels_like"].ToString();
            var minTemp = JObject.Parse(weatherInfo)["main"]["temp_min"].ToString();
            var maxTemp = JObject.Parse(weatherInfo)["main"]["temp_max"].ToString();
            var humidity = JObject.Parse(weatherInfo)["main"]["humidity"].ToString();
            Console.WriteLine($"Here's the weather for {city}:\n" +
                $"The temperature is {temp} degrees F.\n" +
                $"It feels like {feelsLike} degrees F.\n" +
                $"The low is {minTemp} degrees F.\n" +
                $"The high is {maxTemp} degrees F.\n" +
                $"The humidity is {humidity}%.");
        }
    }
}
