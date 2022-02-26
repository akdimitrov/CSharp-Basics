using System;

namespace T08.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            do
            {
                num = num * n;
                n--;
            } while (n > 1);
            Console.WriteLine(num);
        }
    }
}
