using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StrategyPattern.Fly;
using StrategyPattern.Quack;

namespace StrategyPattern.Ducks
{
    public class WoodenDuck : DuckBase
    {
        public WoodenDuck()
        {
            flyBehaviour = new NoFly();
            quackBehaviour = new NoQuack();
        }

        public override void Display()
        {
            Console.WriteLine("Hi! I'm a wooden duck!");
        }
    }
}
