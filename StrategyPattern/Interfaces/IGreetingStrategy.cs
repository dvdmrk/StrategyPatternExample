using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Interfaces
{
    public interface IGreetingStrategy : IBaseStrategy
    {
        void Execute();
    }
}
