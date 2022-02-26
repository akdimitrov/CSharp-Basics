using System;

namespace T01.SeriesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int seasons = int.Parse(Console.ReadLine());
            int episodes = int.Parse(Console.ReadLine());
            double duration = double.Parse(Console.ReadLine());

            double totalTime = episodes * seasons * duration * 1.2 + seasons * 10;
            Console.WriteLine($"Total time needed to watch the {name} series is {Math.Floor(totalTime)} minutes.");
        }
    }
}
