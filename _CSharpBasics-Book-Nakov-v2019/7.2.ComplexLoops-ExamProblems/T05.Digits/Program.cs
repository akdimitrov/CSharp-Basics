using System;

namespace T05.Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int n = num;
            int d3 = n % 10;
            n /= 10;
            int d2 = n % 10;
            n /= 10;
            int d1 = n % 10;

            int rows = d1 + d2;
            int cols = d1 + d3;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (num % 5 == 0)
                    {
                        num -= d1;
                    }
                    else if (num % 3 == 0)
                    {
                        num -= d2;
                    }
                    else
                    {
                        num += d3;
                    }
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
