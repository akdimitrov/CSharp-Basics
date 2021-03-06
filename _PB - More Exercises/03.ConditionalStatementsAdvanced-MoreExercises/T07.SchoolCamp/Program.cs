using System;

namespace T07.SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string group = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double price = 0;
            string sport = "";

            if (season == "Winter")
            {
                switch (group)
                {
                    case "girls": price = 9.60; sport = "Gymnastics"; break;
                    case "boys": price = 9.60; sport = "Judo"; break;
                    case "mixed": price = 10; sport = "Ski"; break;
                }
            }
            else if (season == "Spring")
            {
                switch (group)
                {
                    case "girls": price = 7.20; sport = "Athletics"; break;
                    case "boys": price = 7.20; sport = "Tennis"; break;
                    case "mixed": price = 9.50; sport = "Cycling"; break;
                }
            }
            else if (season == "Summer")
            {
                switch (group)
                {
                    case "girls": price = 15; sport = "Volleyball"; break;
                    case "boys": price = 15; sport = "Football"; break;
                    case "mixed": price = 20; sport = "Swimming"; break;
                }
            }

            price *= students * nights;

            if (students >= 50)
            {
                price *= 0.50;
            }
            else if (students >= 20)
            {
                price *= 0.85;
            }
            else if (students >= 10)
            {
                price *= 0.95;
            }

            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
}
