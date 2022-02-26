using System;

namespace T03.DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            int duration = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());

            double finalSum = sum + duration * (sum * (interest / 100) / 12);
            Console.WriteLine(finalSum);
        }
    }
}
