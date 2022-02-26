using System;

namespace T11.NthDigit
{
    class Program
    {
        static void FindNthDigit(int num, int index)
        {
            string number = num.ToString();
            Console.WriteLine(number[number.Length - index]);
        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            FindNthDigit(number, index);
        }
    }
}
