using System;

namespace T01.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string ticketType = Console.ReadLine();
            int group = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            if (group >= 1 && group <= 4)
            {
                totalPrice = budget * 0.75;
            }
            else if (group <= 9)
            {
                totalPrice = budget * 0.60;
            }
            else if (group <= 24)
            {
                totalPrice = budget * 0.50;
            }
            else if (group <= 49)
            {
                totalPrice = budget * 0.40;
            }
            else
            {
                totalPrice = budget * 0.25;
            }

            if (ticketType == "VIP")
            {
                totalPrice += group * 499.99;
            }
            else
            {
                totalPrice += group * 249.99;
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Yes! You have {budget - totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:f2} leva.");
            }
        }
    }
}
