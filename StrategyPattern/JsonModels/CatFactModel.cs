using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.JsonModels
{
    public class CatFactModel : IInformation
    {
        public string text { get; set; }
        public string Value => text;
    }
}
