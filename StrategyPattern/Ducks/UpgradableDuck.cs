using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StrategyPattern.Fly;
using StrategyPattern.Quack;

namespace StrategyPattern.Ducks
{
    public class UpgradableDuck : DuckBase
    {
        public UpgradableDuck()
        {
            flyBehaviour = new NoFly();
            quackBehaviour = new NoQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm an upgradable duck!");
        }
    }
}
