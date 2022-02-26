using System;

namespace T06.Sums3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int maxNum = int.MinValue;
            int num1 = 0;
            int num2 = 0;


            if (a > maxNum)
            {
                maxNum = a;
                num1 = Math.Min(b, c);
                num2 = Math.Max(b, c);
            }
            if (b > maxNum)
            {
                maxNum = b;
                num1 = Math.Min(a, c);
                num2 = Math.Max(a, c);
            }
            if (c > maxNum)
            {
                maxNum = c;
                num1 = Math.Min(b, a);
                num2 = Math.Max(b, a);
            }



            if (maxNum == num1 + num2)
            {
                Console.WriteLine($"{num1} + {num2} = {maxNum}");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
