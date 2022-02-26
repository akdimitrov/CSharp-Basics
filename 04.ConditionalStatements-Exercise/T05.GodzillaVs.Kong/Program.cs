using System;

namespace T05.GodzillaVs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double suitPrice = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;
            double suitsPrice = suitPrice * statists;

            if (statists > 150)
            {
                suitsPrice *= 0.9;
            }

            double totalCost = decor + suitsPrice;

            if (budget >= totalCost)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalCost:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalCost - budget:f2} leva more.");
            }

        }

    }
}
