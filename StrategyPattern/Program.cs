using StrategyPattern.Interfaces;
using StrategyPattern.Models;
using StrategyPattern.Strategies.QueryingStrategy;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var disposition = "";
            var data = "";
            IGreetingStrategy greeting = null;
            IQueryingStrategy querying = null;

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("----------------Build a Bot 9000----------------");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("");

            do
            {
                Console.WriteLine("Do you want a Smart Bot (1) or a Mean Bot (2)?");
                disposition = Console.ReadLine();
                if (disposition == "1") greeting = new SmartGreetingStrategy();
                else if (disposition == "2") greeting = new MeanGreetingStrategy();
            } while (disposition != "1" && disposition != "2");

            do
            {
                Console.WriteLine("What kind of data do you want?");
                Console.WriteLine("Advice (1), Cat Facts (2), Weather (3)");
                data = Console.ReadLine();
                if (data == "1") querying = new AdviceQueryingStrategy();
                else if (data == "2") querying = new CatFactQueryingStrategy();
                else if (data == "3") querying = new WeatherQueryingStrategy();
            } while (data != "1" && data != "2" && data != "3");

            Robot robot = new Robot(greeting, querying);
            robot.Greet();
            Console.WriteLine($"My name is {robot.Name}!");
            Console.WriteLine($"I have some data for you: {Environment.NewLine}{robot.Query()}");
            Console.ReadKey();
        }
    }
}
