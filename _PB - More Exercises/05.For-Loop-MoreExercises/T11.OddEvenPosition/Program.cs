using System;

namespace T11.OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += num;
                    if (num < evenMin)
                        evenMin = num;
                    if (num > evenMax)
                        evenMax = num;
                }
                else
                {
                    oddSum += num;
                    if (num < oddMin)
                        oddMin = num;
                    if (num > oddMax)
                        oddMax = num;
                }
            }

            Console.WriteLine($"OddSum={oddSum:f2},");
            Console.WriteLine(oddSum == 0 ? "OddMin=No," : $"OddMin={oddMin:f2},");
            Console.WriteLine(oddSum == 0 ? "OddMax=No," : $"OddMax={oddMax:f2},");
            Console.WriteLine($"EvenSum={evenSum:f2},");
            Console.WriteLine(evenSum == 0 ? "EvenMin=No," : $"EvenMin={evenMin:f2},");
            Console.WriteLine(evenSum == 0 ? "EvenMax=No" : $"EvenMax={evenMax:f2}");
        }
    }
}
