using System;

namespace T03.FilmPremiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string bundle = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());
            double price = 0;

            if (movie == "John Wick")
            {
                switch (bundle)
                {
                    case "Drink": price = 12; break;
                    case "Popcorn": price = 15; break;
                    case "Menu": price = 19; break;
                }
            }
            else if (movie == "Star Wars")
            {
                switch (bundle)
                {
                    case "Drink": price = 18; break;
                    case "Popcorn": price = 25; break;
                    case "Menu": price = 30; break;
                }
                if (tickets >= 4)
                {
                    price *= 0.70;
                }
            }
            else if (movie == "Jumanji")
            {
                switch (bundle)
                {
                    case "Drink": price = 9; break;
                    case "Popcorn": price = 11; break;
                    case "Menu": price = 14; break;
                }
                if (tickets == 2)
                {
                    price *= 0.85;
                }
            }

            price *= tickets;

            Console.WriteLine($"Your bill is {price:f2} leva.");
        }
    }
}
