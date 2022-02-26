using System;

namespace T01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            string input = Console.ReadLine();
            int counter = 0;

            while (input != "No More Books" && input != book)
            {
                counter++;
                input = Console.ReadLine();
            }

            if (input == book)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
