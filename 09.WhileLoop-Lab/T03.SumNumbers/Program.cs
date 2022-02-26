using System;

namespace T03.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int sum = 0;

            while (sum < num1)
            {
                int num2 = int.Parse(Console.ReadLine());
                sum += num2;
            }

            Console.WriteLine(sum);
        }
    }
}
