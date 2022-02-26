using System;

namespace T13.PrimePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPairStart = int.Parse(Console.ReadLine());
            int secondPairStar = int.Parse(Console.ReadLine());
            int firstPairDiff = int.Parse(Console.ReadLine());
            int secondPairDiff = int.Parse(Console.ReadLine());
            int diff1 = firstPairStart + firstPairDiff;
            int diff2 = secondPairStar + secondPairDiff;

            for (int num1 = firstPairStart; num1 <= diff1; num1++)
            {
                bool prime1 = true;
                for (int i = 2; i <= Math.Sqrt(num1); i++)
                {
                    if (num1 % i == 0)
                    {
                        prime1 = false;
                    }
                }

                if (prime1)
                {
                    for (int num2 = secondPairStar; num2 <= diff2; num2++)
                    {
                        bool prime2 = true;
                        for (int j = 2; j <= Math.Sqrt(num2); j++)
                        {
                            if (num2 % j == 0)
                            {
                                prime2 = false;
                            }
                        }

                        if (prime2)
                        {
                            Console.WriteLine($"{num1}{num2}");
                        }
                    }
                }
            }
        }
    }
}
