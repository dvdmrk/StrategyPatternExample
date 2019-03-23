using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern.JsonModels
{
    public class WeatherModel : IInformation
    {
        public List<consolidated_weather> consolidated_weather { get; set; }

        public consolidated_weather TodaysWeather => consolidated_weather.FirstOrDefault();
        public string Value => $"Todays low: {TodaysWeather.Low} - Todays high: {TodaysWeather.High}";
    }
    public class consolidated_weather
    {
        public double min_temp { get; set; }
        public double Low => (min_temp * 1.8) + 32;
        public double max_temp { get; set; }
        public double High => (max_temp * 1.8) + 32;
    }
}
