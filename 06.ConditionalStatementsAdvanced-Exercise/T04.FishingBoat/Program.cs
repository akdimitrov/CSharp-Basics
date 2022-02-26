using System;

namespace T04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());
            double boatFee = 0;

            if (season == "Spring")
            {
                boatFee = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                boatFee = 4200;
            }
            else if (season == "Winter")
            {
                boatFee = 2600;
            }

            if (fishers <= 6)
            {
                boatFee *= 0.90;
            }
            else if (fishers <= 11)
            {
                boatFee *= 0.85;
            }
            else
            {
                boatFee *= 0.75;
            }

            if (fishers % 2 == 0 && season != "Autumn")
            {
                boatFee *= 0.95;
            }

            if (budget >= boatFee)
            {
                Console.WriteLine($"Yes! You have {budget - boatFee:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {boatFee - budget:f2} leva.");
            }
        }
    }
}
