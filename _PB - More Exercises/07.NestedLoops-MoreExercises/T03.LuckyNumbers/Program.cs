using System;

namespace T03.LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int num1 = 1; num1 <= 9; num1++)
            {
                for (int num2 = 1; num2 <= 9; num2++)
                {
                    for (int num3 = 1; num3 <= 9; num3++)
                    {
                        for (int num4 = 1; num4 <= 9; num4++)
                        {
                            int sum1 = num1 + num2;
                            int sum2 = num3 + num4;

                            if (sum1 == sum2 && n % sum1 == 0)
                            {
                                Console.Write($"{num1}{num2}{num3}{num4} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
