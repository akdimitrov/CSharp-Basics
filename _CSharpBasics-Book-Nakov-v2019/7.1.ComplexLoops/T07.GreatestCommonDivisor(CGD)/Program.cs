using System;

namespace T07.GreatestCommonDivisor_CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            while (b != 0)
            {
                int oldB = b;
                b = a % b;
                a = oldB;
            }

            Console.WriteLine("GCD = {0}", a);
        }
    }
}
