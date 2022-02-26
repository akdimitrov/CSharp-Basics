using System;

namespace T02.MountainRun
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordSec = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secondsPerOneMeter = double.Parse(Console.ReadLine());

            double delays = Math.Floor(distance / 50);
            double time = distance * secondsPerOneMeter + delays * 30;
            if (time < recordSec)
            {
                Console.WriteLine($"Yes! The new record is {time:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {time - recordSec:f2} seconds slower.");
            }
        }
    }
}
