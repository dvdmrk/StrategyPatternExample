using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Models
{
    public class Robot
    {
        public IGreetingStrategy Greeting;
        public IQueryingStrategy Querying;
        public Robot(IGreetingStrategy greeting, IQueryingStrategy querying)
        {
            Greeting = greeting;
            Querying = querying;
        }

        public void Greet() => Greeting.Execute();
        public string Query() => Querying.Execute();
        public string Name => $"{Querying.Name} mc {Greeting.Name}"; 
    }
}
