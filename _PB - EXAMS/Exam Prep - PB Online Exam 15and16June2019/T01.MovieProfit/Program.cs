using System;

namespace T01.MovieProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            double cinemaCommissionPercent = int.Parse(Console.ReadLine());

            double profit = days * tickets * ticketPrice * (1 - cinemaCommissionPercent / 100);

            Console.WriteLine($"The profit from the movie {movie} is {profit:f2} lv.");
        }
    }
}
