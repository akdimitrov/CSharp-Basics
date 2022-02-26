using System;

namespace Т01.EasterLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int bread = int.Parse(Console.ReadLine());
            int eggs = int.Parse(Console.ReadLine());
            int cookies = int.Parse(Console.ReadLine());
            double eggDyePrice = eggs * 12 * 0.15;
            double price = bread * 3.20 + eggs * 4.35 + cookies * 5.40 + eggDyePrice;

            Console.WriteLine($"{price:f2}");
        }
    }
}
