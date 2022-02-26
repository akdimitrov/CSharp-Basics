using System;

namespace T05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            string input = Console.ReadLine();
            bool isInvalid = false;
            while (input != "NoMoreMoney")
            {
                double sum = double.Parse(input);
                if (sum < 0)
                {
                    isInvalid = true;
                    break;
                }
                total += sum;
                Console.WriteLine($"Increase: {sum:f2}");
                input = Console.ReadLine();
            }

            if (isInvalid)
            {
                Console.WriteLine("Invalid operation!");
            }
            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
