using System;

namespace T12.IntegerToBase
{
    class Program
    {
        static string IntegerToBase(int number, int toBase)
        {
            string result = "";
            while (number != 0)
            {
                int num1 = number % toBase;
                result = num1 + result;
                number /= toBase;
            }

            return result;
        }

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());
            Console.WriteLine(IntegerToBase(num, toBase));
        }
    }
}
