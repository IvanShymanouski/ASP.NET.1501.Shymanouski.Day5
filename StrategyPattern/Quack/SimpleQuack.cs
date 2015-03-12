using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern.Quack
{
    public class SimpleQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack! Quack!");
        }
    }
}
