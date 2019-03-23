using StrategyPattern.Interfaces;
using StrategyPattern.JsonModels;
using StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Strategies.QueryingStrategy
{
    public class AdviceQueryingStrategy : BaseQueryStrategy, IQueryingStrategy
    {
        public new string Name => "Advicey";
        private readonly string url = "https://api.adviceslip.com/advice";
        public string Execute() => GetDataFromJSON<AdviceModel>(ReadDataFromUrl(url));
    }
}
