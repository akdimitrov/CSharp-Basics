using System;

namespace T02.Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlMinutes = int.Parse(Console.ReadLine());
            int controlSeconds = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            int secondsFor100m = int.Parse(Console.ReadLine());

            int controlTime = controlMinutes * 60 + controlSeconds;
            double competitorTime = length / 100.0 * secondsFor100m - (length / 120.0 * 2.5);

            if (competitorTime <= controlTime)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {$"{competitorTime:f3}"}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {$"{competitorTime - controlTime:f3}"} second slower.");
            }
        }
    }
}
