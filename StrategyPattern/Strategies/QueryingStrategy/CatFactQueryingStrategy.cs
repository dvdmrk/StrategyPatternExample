using StrategyPattern.Interfaces;
using StrategyPattern.JsonModels;
using StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Strategies.QueryingStrategy
{
    public class CatFactQueryingStrategy : BaseQueryStrategy, IQueryingStrategy
    {
        public new string Name => "Catty";
        private readonly string url = "https://cat-fact.herokuapp.com/facts/random";
        public string Execute() => GetDataFromJSON<CatFactModel>(ReadDataFromUrl(url));
    }
}
