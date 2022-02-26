using System;

namespace T02.MovieDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int shootingTime = int.Parse(Console.ReadLine());
            int scenes = int.Parse(Console.ReadLine());
            int sceneDuration = int.Parse(Console.ReadLine());

            double totalTime = Math.Round(shootingTime * 0.15 + scenes * sceneDuration);

            if (totalTime <= shootingTime)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {shootingTime - totalTime} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {totalTime - shootingTime} minutes.");
            }
        }
    }
}
