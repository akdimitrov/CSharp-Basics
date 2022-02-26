using System;

namespace T03.PointOnSegment
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());

            int minDistance = Math.Min(first, second);
            int maxDistance = Math.Max(first, second);

            int a = Math.Abs(minDistance - point);
            int b = Math.Abs(maxDistance - point);

            if (minDistance <= point && point <= maxDistance)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
            Console.WriteLine(Math.Min(a, b));
        }
    }
}
