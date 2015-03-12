using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern.Ducks
{
    public class SimpleDuck : DuckBase
    {
        public override void Display()
        {
            Console.WriteLine("Hi! I'm a simle duck.");
        }
    }
}
