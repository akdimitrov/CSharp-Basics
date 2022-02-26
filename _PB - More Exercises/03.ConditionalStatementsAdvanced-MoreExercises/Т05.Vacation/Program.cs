using System;

namespace Т05.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string location = "";
            string type = "";
            double price = 0;

            if (budget <= 1000)
            {
                type = "Camp";
                location = "Alaska";
                price = budget * 0.65;
                if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.45;
                }
            }
            else if (budget <= 3000)
            {
                type = "Hut";
                location = "Alaska";
                price = budget * 0.80;
                if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.60;
                }
            }
            else
            {
                type = "Hotel";
                location = "Alaska";
                price = budget * 0.90;
                if (season == "Winter")
                {
                    location = "Morocco";
                }
            }

            Console.WriteLine($"{location} - {type} - {price:f2}");
        }
    }
}
