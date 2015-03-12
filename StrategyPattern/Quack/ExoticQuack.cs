using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern.Quack
{
    public class ExoticQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Meaow! Meaow!");
        }
    }
}
