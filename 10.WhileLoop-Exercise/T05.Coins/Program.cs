using System;

namespace T05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            amount *= 100;
            int total = (int)amount;
            int coins = 0;

            while (total > 0)
            {
                if (total >= 200)
                    total -= 200;
                else if (total >= 100)
                    total -= 100;
                else if (total >= 50)
                    total -= 50;
                else if (total >= 20)
                    total -= 20;
                else if (total >= 10)
                    total -= 10;
                else if (total >= 5)
                    total -= 5;
                else if (total >= 2)
                    total -= 2;
                else if (total >= 1)
                    total -= 1;

                coins++;
            }

            Console.WriteLine(coins);
        }
    }
}
