using System;

namespace T02.Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            double totalCost = 0;

            totalCost += fuel * 2.10 + 100;
            if (day == "Saturday")
            {
                totalCost *= 0.9;
            }
            else if (day == "Sunday")
            {
                totalCost *= 0.8;
            }

            if (budget >= totalCost)
            {
                Console.WriteLine($"Safari time! Money left: {budget - totalCost:f2} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {totalCost - budget:f2} lv.");
            }
        }
    }
}
