using System;

namespace T01.TennisEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal tennisRacketPrice = decimal.Parse(Console.ReadLine());
            int tennisRackets = int.Parse(Console.ReadLine());
            int pairOfShoes = int.Parse(Console.ReadLine());

            decimal totalPrice = tennisRacketPrice * tennisRackets + pairOfShoes * (tennisRacketPrice / 6);
            totalPrice *= 1.20m;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(totalPrice / 8)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(totalPrice * 7 / 8)}");
        }
    }
}
