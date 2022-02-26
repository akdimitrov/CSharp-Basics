using System;

namespace T06.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            double totalTickests = 0;
            double student = 0;
            double standard = 0;
            double kid = 0;

            while (movie != "Finish")
            {
                double tickets = 0;
                int seats = int.Parse(Console.ReadLine());
                string type = Console.ReadLine();

                while (type != "End")
                {
                    tickets++;
                    switch (type)
                    {
                        case "student": student++; break;
                        case "standard": standard++; break;
                        case "kid": kid++; break;
                    }

                    if (seats <= tickets)
                        break;
                    type = Console.ReadLine();
                }

                totalTickests += tickets;
                Console.WriteLine($"{movie} - {tickets / seats * 100:f2}% full.");
                movie = Console.ReadLine();
            }

            Console.WriteLine($"Total tickets: {totalTickests}");
            Console.WriteLine($"{student / totalTickests * 100:f2}% student tickets.");
            Console.WriteLine($"{standard / totalTickests * 100:f2}% standard tickets.");
            Console.WriteLine($"{kid / totalTickests * 100:f2}% kids tickets.");
        }
    }
}
