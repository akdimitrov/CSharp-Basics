using System;

namespace T01.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                    if (num > n)
                    {
                        return;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
