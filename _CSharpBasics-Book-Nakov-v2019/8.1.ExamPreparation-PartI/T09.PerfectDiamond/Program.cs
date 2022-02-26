using System;

namespace T09.PerfectDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', n - row));
                Console.Write("*");
                for (int col = 1; col < row; col++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine(new string(' ', n - row));
            }
            for (int row = n - 1; row >= 1; row--)
            {
                Console.Write(new string(' ', n - row));
                Console.Write("*");
                for (int col = 1; col < row; col++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine(new string(' ', n - row));
            }
        }
    }
}
