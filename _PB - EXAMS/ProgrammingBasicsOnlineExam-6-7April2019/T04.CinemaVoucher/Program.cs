using System;

namespace T04.CinemaVoucher
{
    class Program
    {
        static void Main(string[] args)
        {
            int voucher = int.Parse(Console.ReadLine());
            string purchase = Console.ReadLine();
            int tickets = 0;
            int others = 0;

            while (purchase != "End")
            {
                if (purchase.Length > 8)
                {
                    voucher -= purchase[0] + purchase[1];
                    if (voucher < 0)
                    {
                        break;
                    }
                    tickets++;
                }
                else
                {
                    voucher -= purchase[0];
                    if (voucher < 0)
                    {
                        break;
                    }
                    others++;
                }

                purchase = Console.ReadLine();
            }

            Console.WriteLine(tickets);
            Console.WriteLine(others);
        }
    }
}
