using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.JsonModels
{
    public class AdviceModel : IInformation
    {
        public slip slip { get; set; }
        public string Value => slip.advice;
    }

    public class slip
    {
        public string advice { get; set; }
    }
}
