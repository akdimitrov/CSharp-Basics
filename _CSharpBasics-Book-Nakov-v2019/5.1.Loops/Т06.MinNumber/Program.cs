using System;

namespace Т06.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int minNum = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < minNum)
                {
                    minNum = num;
                }
            }

            Console.WriteLine(minNum);
        }
    }
}
