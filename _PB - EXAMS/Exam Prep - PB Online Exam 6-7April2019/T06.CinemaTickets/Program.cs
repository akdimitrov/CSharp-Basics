using System;

namespace T06.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            double student = 0;
            double standard = 0;
            double kid = 0;
            double totalTickets = 0;

            while (movie != "Finish")
            {
                double soldTickets = 0;
                int freeSeats = int.Parse(Console.ReadLine());
                for (int i = 0; i < freeSeats; i++)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }
                    soldTickets++;
                    switch (ticketType)
                    {
                        case "student": student++; break;
                        case "standard": standard++; break;
                        case "kid": kid++; break;
                    }
                }

                totalTickets += soldTickets;
                Console.WriteLine($"{movie} - {soldTickets / freeSeats * 100:f2}% full.");
                movie = Console.ReadLine();
            }

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{student / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{standard / totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{kid / totalTickets * 100:f2}% kids tickets.");
        }
    }
}
