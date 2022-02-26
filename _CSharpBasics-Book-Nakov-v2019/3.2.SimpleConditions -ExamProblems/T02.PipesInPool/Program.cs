using System;

namespace T02.PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int poolVolume = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double p1Total = p1 * hours;
            double p2Total = p2 * hours;
            double totalPipesVolume = p1Total + p2Total;
            double totalVolumePercent = totalPipesVolume / poolVolume * 100;
            double p1VolumePercents = p1Total / totalPipesVolume * 100;
            double p2VolumePercents = p2Total / totalPipesVolume * 100;


            if (poolVolume >= totalPipesVolume)
            {
                Console.WriteLine($"The pool is {Math.Floor(totalVolumePercent)}% full. Pipe 1: {Math.Floor(p1VolumePercents)}%. Pipe 2: {Math.Floor(p2VolumePercents)}%.");
            }
            else
            {
                Console.WriteLine($"For {hours} hours the pool overflows with {totalPipesVolume - poolVolume} liters.");
            }


        }
    }
}
