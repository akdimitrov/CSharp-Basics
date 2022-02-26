using System;

namespace T01.AgencyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string company = Console.ReadLine();
            int adultTickets = int.Parse(Console.ReadLine());
            int kidTickets = int.Parse(Console.ReadLine());
            double adultNetPrice = double.Parse(Console.ReadLine());
            double fee = double.Parse(Console.ReadLine());

            double kidNetPrice = adultNetPrice * 0.3;
            double kidTicketPrice = kidNetPrice + fee;
            double adultTicketPrice = adultNetPrice + fee;
            double total = adultTickets * adultTicketPrice + kidTickets * kidTicketPrice;
            total *= 0.2;

            Console.WriteLine($"The profit of your agency from {company} tickets is {total:f2} lv.");
        }
    }
}
