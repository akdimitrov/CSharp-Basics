using System;

namespace T02.FamilyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            int additionalExpensesPercent = int.Parse(Console.ReadLine());

            double totalCost = 0;
            totalCost = pricePerNight * nights;
            if (nights > 7)
            {
                totalCost *= 0.95;
            }

            totalCost += budget * additionalExpensesPercent / 100;
            if (budget >= totalCost)
            {
                Console.WriteLine($"Ivanovi will be left with {budget - totalCost:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{totalCost - budget:f2} leva needed.");
            }
        }
    }
}
