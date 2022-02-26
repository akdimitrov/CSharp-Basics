using System;

namespace T10_1.RectangleWithStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rows = n;

            if (n % 2 == 0)
            {
                rows--;
            }

            Console.WriteLine(new string('%', n * 2));

            for (int row = 0; row < rows; row++)
            {
                Console.Write("%");

                if (rows / 2 == row)
                {
                    Console.Write(new string(' ', n - 2));
                    Console.Write("**");
                    Console.Write(new string(' ', n - 2));
                }
                else
                {
                    Console.Write(new string(' ', n * 2 - 2));
                }

                Console.WriteLine("%");
            }

            Console.WriteLine(new string('%', n * 2));
        }
    }
}
