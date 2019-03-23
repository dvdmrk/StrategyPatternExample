using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Models
{
    public class MeanGreetingStrategy : BaseStrategy, IGreetingStrategy
    {
        public new string Name => "MeaniePants";
        public void Execute() => Console.WriteLine("You're a llama!");
    }
}
