using System;

namespace T08.LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int movieDuration = int.Parse(Console.ReadLine());
            double breakTime = int.Parse(Console.ReadLine());

            double timeForLunch = breakTime / 4;
            double timeForRelax = breakTime / 8;
            double freeTime = breakTime - timeForLunch - timeForRelax;

            if (movieDuration <= freeTime)
            {
                Console.WriteLine($"You have enough time to watch {movie} and left with {Math.Ceiling(freeTime - movieDuration)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {movie}, you need {Math.Ceiling(movieDuration - freeTime)} more minutes.");
            }
        }
    }
}
