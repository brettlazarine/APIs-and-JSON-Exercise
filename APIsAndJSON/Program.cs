﻿using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            RonVSKanyeAPI.GetKanyeQuote();
            RonVSKanyeAPI.GetRonQuote();
            OpenWeatherMapAPI.GetWeather();
        }
    }
}
