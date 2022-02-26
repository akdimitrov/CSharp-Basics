using System;

namespace T05.InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool InRange = num >= 100 && num <= 200 || num == 0;
            if (!InRange)
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
