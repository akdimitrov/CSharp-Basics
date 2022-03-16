using System;

namespace T03.EnergyBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0;

            if (size == "small")
            {
                price = 2;
                switch (fruit)
                {
                    case "Watermelon": price *= 56; break;
                    case "Mango": price *= 36.66; break;
                    case "Pineapple": price *= 42.10; break;
                    case "Raspberry": price *= 20; break;
                }
            }
            else if (size == "big")
            {
                price = 5;
                switch (fruit)
                {
                    case "Watermelon": price *= 28.70; break;
                    case "Mango": price *= 19.60; break;
                    case "Pineapple": price *= 24.80; break;
                    case "Raspberry": price *= 15.20; break;
                }
            }

            price *= quantity;
            if (price > 1000)
            {
                price *= 0.5;
            }
            else if (price >= 400)
            {
                price *= 0.85;
            }

            Console.WriteLine($"{price:f2} lv.");
        }
    }
}
