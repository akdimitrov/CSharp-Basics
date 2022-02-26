using System;

namespace T04.VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int bookPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            Console.WriteLine(bookPages / pagesPerHour / days);
        }
    }
}
