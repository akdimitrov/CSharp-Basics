using System;

namespace T09.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 1; i <= n * 2; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i <= n)
                {
                    sum1 += num;
                }
                else
                {
                    sum2 += num;
                }
            }

            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum1 - sum2)}");
            }
        }
    }
}
