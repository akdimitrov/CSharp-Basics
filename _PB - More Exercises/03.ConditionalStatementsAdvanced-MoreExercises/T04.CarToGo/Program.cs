using System;

namespace T04.CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string carClass = "";
            string carType = "";
            double price = 0;

            if (budget <= 100)
            {
                carClass = "Economy class";
                carType = "Cabrio";
                price = budget * 0.35;
                if (season == "Winter")
                {
                    carType = "Jeep";
                    price = budget * 0.65;
                }
            }
            else if (budget <= 500)
            {
                carClass = "Compact class";
                carType = "Cabrio";
                price = budget * 0.45;
                if (season == "Winter")
                {
                    carType = "Jeep";
                    price = budget * 0.80;
                }
            }
            else
            {
                carClass = "Luxury class";
                carType = "Jeep";
                price = budget * 0.90;
            }

            Console.WriteLine(carClass);
            Console.WriteLine($"{carType} - {price:f2}");
        }
    }
}
