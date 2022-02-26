using System;

namespace T12.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int previousSum = 0;
            int lastSum = 0;
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                if (i > 0)
                {
                    previousSum = lastSum;
                    lastSum = num1 + num2;
                }
                else
                {
                    lastSum = num1 + num2;
                }

                if (lastSum == previousSum)
                {
                    counter++;
                }
            }

            if (counter == n - 1)
            {
                Console.WriteLine($"Yes, value={lastSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={Math.Abs(lastSum - previousSum)}");
            }
        }
    }
}
