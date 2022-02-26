using System;

namespace T03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;

            if (flowers == "Roses")
            {
                price = amount * 5.0;
                if (amount > 80)
                {
                    price *= 0.90;
                }
            }
            else if (flowers == "Dahlias")
            {
                price = amount * 3.80;
                if (amount > 90)
                {
                    price *= 0.85;
                }
            }
            else if (flowers == "Tulips")
            {
                price = amount * 2.80;
                if (amount > 80)
                {
                    price *= 0.85;
                }
            }
            else if (flowers == "Narcissus")
            {
                price = amount * 3.00;
                if (amount < 120)
                {
                    price *= 1.15;
                }
            }
            else if (flowers == "Gladiolus")
            {
                price = amount * 2.50;
                if (amount < 80)
                {
                    price *= 1.20;
                }
            }

            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {amount} {flowers} and {budget - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {price - budget:f2} leva more.");
            }
        }
    }
}
