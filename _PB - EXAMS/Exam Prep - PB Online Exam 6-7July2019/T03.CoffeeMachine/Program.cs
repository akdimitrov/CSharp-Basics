using System;

namespace T03.CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double price = 0;

            if (drink == "Espresso")
            {
                switch (sugar)
                {
                    case "Without": price = 0.90; break;
                    case "Normal": price = 1; break;
                    case "Extra": price = 1.20; break;
                }
            }
            else if (drink == "Cappuccino")
            {
                switch (sugar)
                {
                    case "Without": price = 1; break;
                    case "Normal": price = 1.20; break;
                    case "Extra": price = 1.60; break;
                }
            }
            else if (drink == "Tea")
            {
                switch (sugar)
                {
                    case "Without": price = 0.50; break;
                    case "Normal": price = 0.60; break;
                    case "Extra": price = 0.70; break;
                }
            }

            price *= count;

            if (sugar == "Without")
            {
                price *= 0.65;
            }

            if (drink == "Espresso" && count >= 5)
            {
                price *= 0.75;
            }

            if (price > 15)
            {
                price *= 0.80;
            }

            Console.WriteLine($"You bought {count} cups of {drink} for {price:f2} lv.");
        }
    }
}
