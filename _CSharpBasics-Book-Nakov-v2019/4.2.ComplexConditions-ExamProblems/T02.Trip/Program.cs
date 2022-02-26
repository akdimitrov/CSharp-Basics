using System;

namespace T02.Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string type = "";
            double spentMoney = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer": type = "Camp"; spentMoney = budget * 0.3; break;
                    case "winter": type = "Hotel"; spentMoney = budget * 0.7; break;
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer": type = "Camp"; spentMoney = budget * 0.4; break;
                    case "winter": type = "Hotel"; spentMoney = budget * 0.8; break;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                type = "Hotel";
                spentMoney = budget * 0.9;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {spentMoney:f2}");
        }
    }
}
