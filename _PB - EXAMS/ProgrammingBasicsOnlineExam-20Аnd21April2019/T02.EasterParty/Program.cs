using System;

namespace T02.EasterParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            double pricePerPerson = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            if (guests > 20)
            {
                pricePerPerson *= 0.75;
            }
            else if (guests > 15)
            {
                pricePerPerson *= 0.80;
            }
            else if (guests >= 10)
            {
                pricePerPerson *= 0.85;
            }

            double cakePrice = budget * 0.1;
            double totalSum = cakePrice + pricePerPerson * guests;

            if (budget >= totalSum)
            {
                Console.WriteLine($"It is party time! {budget - totalSum:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {totalSum - budget:f2} leva needed.");
            }
        }
    }
}
