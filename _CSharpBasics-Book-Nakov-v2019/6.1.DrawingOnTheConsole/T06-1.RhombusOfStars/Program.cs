using System;

namespace T06_1.RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n - row; col++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int i = 1; i < row; i++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            for (int row = n - 1; row >= 1; row--)
            {
                for (int col = 1; col <= n - row; col++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int i = 1; i < row; i++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
