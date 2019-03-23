using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Models
{
    public class SmartGreetingStrategy : BaseStrategy, IGreetingStrategy
    {
        public new string Name => "SmartiePants";

        public void Execute() => Console.WriteLine("E = MC^2");
    }
}
