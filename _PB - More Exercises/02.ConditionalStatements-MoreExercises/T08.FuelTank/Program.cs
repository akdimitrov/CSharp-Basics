using System;

namespace T08.FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine().ToLower();
            double litres = double.Parse(Console.ReadLine());

            if (fuel == "diesel" || fuel == "gasoline" || fuel == "gas")
            {
                Console.WriteLine(litres >= 25 ? $"You have enough {fuel}." : $"Fill your tank with {fuel}!");
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
