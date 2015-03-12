using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StrategyPattern.Quack;

namespace StrategyPattern.Ducks
{
    public class ExoticDuck : DuckBase
    {
        public ExoticDuck()
        {
            quackBehaviour = new ExoticQuack();
        }

        public override void Display()
        {
            Console.WriteLine("Hi! I'm an exotic duck.");
        }
    }
}
