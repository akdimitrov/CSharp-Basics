using System;

namespace T03.MovieDestination
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double price = days;

            if (season == "Winter")
            {
                switch (destination)
                {
                    case "Dubai": price *= 45000; break;
                    case "Sofia": price *= 17000; break;
                    case "London": price *= 24000; break;
                }
            }
            else if (season == "Summer")
            {
                switch (destination)
                {
                    case "Dubai": price *= 40000; break;
                    case "Sofia": price *= 12500; break;
                    case "London": price *= 20250; break;
                }
            }

            if (destination == "Dubai")
            {
                price *= 0.70;
            }
            else if (destination == "Sofia")
            {
                price *= 1.25;
            }

            if (budget >= price)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {budget - price:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {price - budget:f2} leva more!");
            }
        }
    }
}
