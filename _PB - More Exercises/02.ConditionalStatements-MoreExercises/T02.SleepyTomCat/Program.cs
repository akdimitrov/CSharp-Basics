using System;

namespace T02.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());
            int maxPlayTime = 30000;
            int totalPlayTime = (365 - daysOff) * 63 + daysOff * 127;
            int playHours = Math.Abs((totalPlayTime - maxPlayTime) / 60);
            int playMinutes = Math.Abs((totalPlayTime - maxPlayTime) % 60);

            if (totalPlayTime <= maxPlayTime)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{playHours} hours and {playMinutes} minutes less for play");
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{playHours} hours and {playMinutes} minutes more for play");
            }
        }
    }
}
