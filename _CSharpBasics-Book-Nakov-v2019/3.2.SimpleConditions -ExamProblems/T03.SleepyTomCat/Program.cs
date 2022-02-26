using System;

namespace T03.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());

            int totalPlayTime = daysOff * 127 + ((365 - daysOff) * 63);
            int difference = Math.Abs(totalPlayTime - 30000);
            int hours = difference / 60;
            int minutes = difference % 60;

            if (totalPlayTime > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
        }
    }
}
