using System;

namespace T12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekendsAtHomeCity = int.Parse(Console.ReadLine());

            double SofiaSaturdayGames = (48 - weekendsAtHomeCity) * 3 / 4.0;
            double holidayGames = holidays * 2 / 3.0;
            double totalGames = SofiaSaturdayGames + holidayGames + weekendsAtHomeCity;

            if (year == "leap")
            {
                totalGames *= 1.15;
            }
            Console.WriteLine(Math.Floor(totalGames));
        }
    }
}
