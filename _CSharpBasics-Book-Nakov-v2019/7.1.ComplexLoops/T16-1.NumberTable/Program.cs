using System;

namespace T16_1.NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                int num = row;
                bool hasReached = false;

                for (int col = 1; col <= n; col++)
                {
                    Console.Write(num + " ");

                    if (num == n)
                    {
                        hasReached = true;
                    }
                    if (hasReached)
                    {
                        num--;
                    }
                    else
                    {
                        num++;
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
