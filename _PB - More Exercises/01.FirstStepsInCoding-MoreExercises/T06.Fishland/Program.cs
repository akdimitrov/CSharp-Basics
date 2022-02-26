using System;

namespace T06.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double mackerelPrice = double.Parse(Console.ReadLine());
            double spratPrice = double.Parse(Console.ReadLine());
            double bonitoWeight = double.Parse(Console.ReadLine());
            double scadWeight = double.Parse(Console.ReadLine());
            double musselsWeight = double.Parse(Console.ReadLine());

            double bonitoPrice = mackerelPrice * 1.6 * bonitoWeight;
            double scadPrice = spratPrice * 1.8 * scadWeight;
            double musselsPrice = musselsWeight * 7.5;
            double totalPrice = bonitoPrice + scadPrice + musselsPrice;
            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
