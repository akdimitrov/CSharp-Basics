using System;

namespace T01.PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int poolVolume = int.Parse(Console.ReadLine());
            int pipe1 = int.Parse(Console.ReadLine());
            int pipe2 = int.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double pipe1Volume = time * pipe1;
            double pipe2Volume = time * pipe2;
            double totalPipesVolume = pipe1Volume + pipe2Volume;
            double pipe1Percent = pipe1Volume / totalPipesVolume * 100;
            double pipe2Percent = pipe2Volume / totalPipesVolume * 100;
            double poolFilledPercent = totalPipesVolume / poolVolume * 100;

            if (poolVolume >= totalPipesVolume)
            {
                Console.WriteLine($"The pool is {poolFilledPercent:f2}% full. Pipe 1: {pipe1Percent:f2}%. Pipe 2: {pipe2Percent:f2}%.");
            }
            else
            {
                Console.WriteLine($"For {time:f2} hours the pool overflows with {totalPipesVolume - poolVolume:f2} liters.");
            }

        }
    }
}
