using System;

namespace T01.TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double columns = Math.Floor((width - 1) / 0.7);
            double rows = Math.Floor(length / 1.2);
            double workstations = columns * rows - 3;
            Console.WriteLine(workstations);

        }
    }
}
