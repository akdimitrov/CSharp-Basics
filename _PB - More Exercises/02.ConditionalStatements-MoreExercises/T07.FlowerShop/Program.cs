using System;

namespace T07.FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolias = int.Parse(Console.ReadLine());
            int hyacinths = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactuses = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double profit = 0.95 * (magnolias * 3.25 + hyacinths * 4 + roses * 3.50 + cactuses * 8);

            if (profit >= giftPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(profit - giftPrice)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice - profit)} leva.");
            }
        }
    }
}
