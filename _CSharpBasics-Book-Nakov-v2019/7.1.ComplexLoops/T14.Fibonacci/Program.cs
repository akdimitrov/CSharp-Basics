using System;

namespace T14.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            int previousNum = 1;

            for (int i = 1; i <= n - 1; i++)
            {
                int fibonacciNum = previousNum + num;
                previousNum = num;
                num = fibonacciNum;
            }

            Console.WriteLine(num);
        }
    }
}
