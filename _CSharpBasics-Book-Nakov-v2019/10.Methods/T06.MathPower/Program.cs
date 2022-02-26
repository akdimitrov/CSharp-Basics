using System;

namespace T06.MathPower
{
    class Program
    {
        static double NumPower(double num, double power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= num;
            }
            return result;
        }
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = NumPower(num, power);
            Console.WriteLine(result);
        }
    }
}
