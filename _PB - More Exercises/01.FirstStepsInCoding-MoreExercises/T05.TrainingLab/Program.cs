using System;

namespace T05.TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double rows = Math.Floor(length / 1.2);
            double cols = Math.Floor((width - 1) / 0.7);
            double totalWorkStatitons = rows * cols - 3;

            Console.WriteLine(totalWorkStatitons);
        }
    }
}
