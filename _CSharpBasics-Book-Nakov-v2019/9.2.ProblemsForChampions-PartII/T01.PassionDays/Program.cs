using System;

namespace T01.PassionDays
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int purchaseCount = 0;

            string command = Console.ReadLine();
            while (command != "mall.Enter")
            {
                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            while (command != "mall.Exit")
            {
                for (int i = 0; i < command.Length; i++)
                {
                    decimal currentPrice = 0;
                    char product = command[i];
                    if (product >= 65 && product <= 90)
                    {
                        currentPrice = product * 0.5m;
                        if (currentPrice <= money)
                        {
                            money -= currentPrice;
                            purchaseCount++;
                        }
                    }
                    else if (product >= 97 && product <= 122)
                    {
                        currentPrice = product * 0.3m;
                        if (currentPrice <= money)
                        {
                            money -= currentPrice;
                            purchaseCount++;
                        }
                    }
                    else if (product == '%')
                    {
                        if (money > 0)
                        {
                            money /= 2;
                            purchaseCount++;
                        }
                    }
                    else if (product == '*')
                    {
                        money += 10;
                    }
                    else
                    {
                        currentPrice = product;
                        if (currentPrice <= money)
                        {
                            money -= currentPrice;
                            purchaseCount++;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            if (purchaseCount > 0)
            {
                Console.WriteLine($"{purchaseCount} purchases. Money left: {money:f2} lv.");
            }
            else
            {
                Console.WriteLine($"No purchases. Money left: {money:f2} lv.");
            }
        }
    }
}
