using System;

namespace T06.TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());
            double wage = 0;

            if (kmPerMonth <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn": wage = 0.75; break;
                    case "Summer": wage = 0.90; break;
                    case "Winter": wage = 1.05; break;
                }
            }
            else if (kmPerMonth <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn": wage = 0.95; break;
                    case "Summer": wage = 1.10; break;
                    case "Winter": wage = 1.25; break;
                }
            }
            else if (kmPerMonth <= 20000)
            {
                wage = 1.45;
            }

            wage *= kmPerMonth * 4 * 0.9;
            Console.WriteLine($"{wage:f2}");
        }
    }
}
