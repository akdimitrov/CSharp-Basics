using System;

namespace T08.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int lastSum = 0;
            int maxDiff = 0;
            bool isEqual = true;

            for (int i = 0; i < n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                sum = num1 + num2;

                if (i > 0 && sum != lastSum && Math.Abs(sum - lastSum) > maxDiff)
                {
                    maxDiff = Math.Abs(sum - lastSum);
                    isEqual = false;
                }

                lastSum = sum;
            }

            if (isEqual)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
