using System;

namespace T02.GodzillaVs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double suitPrice = double.Parse(Console.ReadLine());

            double decorPrice = budget * 0.1;
            double totalSuitPrice = suitPrice * statists;
            if (statists > 150)
            {
                totalSuitPrice *= 0.9;
            }

            double total = decorPrice + totalSuitPrice;

            if (total > budget)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {total - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - total:f2} leva left.");
            }
        }
    }
}
