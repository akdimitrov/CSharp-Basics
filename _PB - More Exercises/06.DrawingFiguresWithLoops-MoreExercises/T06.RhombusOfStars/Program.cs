using System;

namespace T06.RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    if (col <= n - row)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");

                        if (row > 1)
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }

            for (int row = n - 1; row >= 1; row--)
            {
                for (int col = 1; col <= n; col++)
                {
                    if (col <= n - row)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");

                        if (row > 1)
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
