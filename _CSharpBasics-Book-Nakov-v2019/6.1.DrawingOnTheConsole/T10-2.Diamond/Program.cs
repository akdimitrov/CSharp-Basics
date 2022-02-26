using System;

namespace T10_2.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int mid = -1;
            if (n % 2 == 0) mid = 0;

            for (int row = 1; row <= (n + 1) / 2; row++)
            {
                int left = (n - 2 - mid) / 2;
                Console.Write(new string('-', left));
                Console.Write("*");
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                Console.Write(new string('-', left));
                Console.WriteLine();
                mid += 2; 
            }
            mid = n - 4;
            for (int row = 1; row < (n + 1) / 2; row++)
            {
                int left = (n - 2 - mid) / 2;
                Console.Write(new string('-', left));
                Console.Write("*");
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                Console.Write(new string('-', left));
                Console.WriteLine();
                mid -= 2;
            }
        }
    }
}
