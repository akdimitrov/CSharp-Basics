using System;

namespace T02.Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            int bricks = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int trolleyVolume = int.Parse(Console.ReadLine());

            double courses = 1.0 * bricks / (workers * trolleyVolume);
            Console.WriteLine(Math.Ceiling(courses));
        }
    }
}
