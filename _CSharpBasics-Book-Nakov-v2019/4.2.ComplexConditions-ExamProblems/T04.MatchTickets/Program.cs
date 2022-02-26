using System;

namespace T04.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            //На първия ред е бюджетът – реално число в интервала[1 000.00 … 1 000 000.00].
            //На втория ред е категорията – "VIP" или "Normal".
            //На третия ред е броят на хората в групата – цяло число в интервала[1 … 200].

            double budget = double.Parse(Console.ReadLine());
            string ticketType = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            double transportCost = 0;
            double ticketsPrice = 0;

            if (people >= 50)
            {
                transportCost = budget * 0.25;
            }
            else if (people >= 25)
            {
                transportCost = budget * 0.40;
            }
            else if (people >= 10)
            {
                transportCost = budget * 0.50;
            }
            else if (people >= 5)
            {
                transportCost = budget * 0.60;
            }
            else if (people >= 1)
            {
                transportCost = budget * 0.75;
            }

            switch (ticketType)
            {
                case "VIP": ticketsPrice = people * 499.99; break;
                case "Normal": ticketsPrice = people * 249.99; break;
            }

            double totalCost = transportCost + ticketsPrice;

            if (budget >= totalCost)
            {
                Console.WriteLine($"Yes! You have {budget - totalCost:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalCost - budget:f2} leva.");
            }
        }
    }
}
