using System;

namespace T03.EasterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            int nightsNum = int.Parse(Console.ReadLine());
            double pricePerNight = 0;

            if (dates == "21-23")
            {
                switch (destination)
                {
                    case "France": pricePerNight = 30; break;
                    case "Italy": pricePerNight = 28; break;
                    case "Germany": pricePerNight = 32; break;
                }
            }
            else if (dates == "24-27")
            {
                switch (destination)
                {
                    case "France": pricePerNight = 35; break;
                    case "Italy": pricePerNight = 32; break;
                    case "Germany": pricePerNight = 37; break;
                }
            }
            else
            {
                switch (destination)
                {
                    case "France": pricePerNight = 40; break;
                    case "Italy": pricePerNight = 39; break;
                    case "Germany": pricePerNight = 43; break;
                }
            }

            double tripPrice = pricePerNight * nightsNum;
            Console.WriteLine($"Easter trip to {destination} : {tripPrice:f2} leva.");
        }
    }
}
