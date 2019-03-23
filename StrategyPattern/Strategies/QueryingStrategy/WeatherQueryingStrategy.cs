using StrategyPattern.Interfaces;
using StrategyPattern.JsonModels;
using StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace StrategyPattern.Strategies.QueryingStrategy
{
    public class WeatherQueryingStrategy : BaseQueryStrategy, IQueryingStrategy
    {
        public new string Name => "Stormy";
        private readonly string url = "https://www.metaweather.com/api/location/2442327/";
        public string Execute() => GetDataFromJSON<WeatherModel>(ReadDataFromUrl(url));
    }
}
