using System;

namespace T09.MinMethod
{
    class Program
    {
        static int GetMin(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int min = GetMin(GetMin(num1, num2), num3);
            Console.WriteLine(min);
        }
    }
}
