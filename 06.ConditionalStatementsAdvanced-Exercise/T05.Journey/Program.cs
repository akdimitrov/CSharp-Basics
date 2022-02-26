using System;

namespace T05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = budget;
            string destination = "";
            string type = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    price *= 0.30;
                    type = "Camp";
                }
                else if (season == "winter")
                {
                    price *= 0.70;
                    type = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    price *= 0.40;
                    type = "Camp";
                }
                else if (season == "winter")
                {
                    price *= 0.80;
                    type = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                price *= 0.90;
                type = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {price:f2}");
        }
    }
}
