using System;

namespace T02.ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int profitTarget = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int counter = 0;
            double sales = 0;
            int cashPayments = 0;
            int cardPayments = 0;
            double cashPaymentTotal = 0;
            double cardPaymentTotal = 0;

            while (command != "End")
            {
                counter++;
                int price = int.Parse(command);

                if (counter % 2 == 0)
                {
                    if (price >= 10)
                    {
                        sales += price;
                        cardPaymentTotal += price;
                        cardPayments++;

                        Console.WriteLine("Product sold!");
                    }
                    else
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                }
                else
                {
                    if (price <= 100)
                    {
                        sales += price;
                        cashPaymentTotal += price;
                        cashPayments++;
                        Console.WriteLine("Product sold!");
                    }
                    else
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                }

                if (sales >= profitTarget)
                {
                    break;
                }

                command = Console.ReadLine();
            }

            if (command != "End")
            {
                Console.WriteLine($"Average CS: {cashPaymentTotal / cashPayments:f2}");
                Console.WriteLine($"Average CC: {cardPaymentTotal / cardPayments:f2}");
            }
            else
            {
                Console.WriteLine($"Failed to collect required money for charity.");
            }
        }
    }
}
