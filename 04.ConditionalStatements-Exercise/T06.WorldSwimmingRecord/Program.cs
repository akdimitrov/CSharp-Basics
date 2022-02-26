using System;

namespace T06.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secodsPerM = double.Parse(Console.ReadLine());

            double delayTimes = Math.Floor(distance / 15);
            double delayTotal = delayTimes * 12.5;
            double attemptIvan = distance * secodsPerM + delayTotal;

            if (record > attemptIvan)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {attemptIvan:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {attemptIvan - record:f2} seconds slower.");
            }

        }
    }
}
