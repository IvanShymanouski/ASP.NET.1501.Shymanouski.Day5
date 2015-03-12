using System;
using AdapterPattern.HomeCats;

namespace AdapterPattern
{
    class CatInfoPrinter
    {
        public static void PrintCatInfo(IHomeCat cat)
        {
            Console.WriteLine("Кошачье досье:");
            Console.WriteLine(string.Format("Имя кота: {0}", cat.Name));
            Console.Write("Вид мяуканья: ");
            cat.Meow();
            Console.Write("Вид царапанья: ");
            cat.Scratch();

            Console.WriteLine();
        }
    }
}
