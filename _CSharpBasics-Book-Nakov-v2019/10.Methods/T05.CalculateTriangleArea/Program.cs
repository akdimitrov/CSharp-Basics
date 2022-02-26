using System;

namespace T05.CalculateTriangleArea
{
    class Program
    {
        static double TriangleArea(double a, double h)
        {
            return a * h / 2;
        }
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = TriangleArea(a, h);
            Console.WriteLine(area);
        }
    }
}
