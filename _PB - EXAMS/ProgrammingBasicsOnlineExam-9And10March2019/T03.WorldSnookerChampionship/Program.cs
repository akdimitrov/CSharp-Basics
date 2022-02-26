using System;

namespace T03.WorldSnookerChampionship
{
    class Program
    {
        static void Main(string[] args)
        {
            string competitionStage = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int ticktes = int.Parse(Console.ReadLine());
            char photo = char.Parse(Console.ReadLine());
            double price = 0;

            if (competitionStage == "Quarter final")
            {
                switch (ticketType)
                {
                    case "Standard": price = 55.50; break;
                    case "Premium": price = 105.20; break;
                    case "VIP": price = 118.90; break;
                }
            }
            else if (competitionStage == "Semi final")
            {
                switch (ticketType)
                {
                    case "Standard": price = 75.88; break;
                    case "Premium": price = 125.22; break;
                    case "VIP": price = 300.40; break;
                }
            }
            else if (competitionStage == "Final")
            {
                switch (ticketType)
                {
                    case "Standard": price = 110.10; break;
                    case "Premium": price = 160.66; break;
                    case "VIP": price = 400; break;
                }
            }

            price *= ticktes;
            if (price > 4000)
            {
                price *= 0.75;
            }
            else if (price > 2500)
            {
                price *= 0.90;
                if (photo == 'Y')
                {
                    price += ticktes * 40;
                }
            }
            else if (photo == 'Y')
            {
                price += ticktes * 40;
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}
