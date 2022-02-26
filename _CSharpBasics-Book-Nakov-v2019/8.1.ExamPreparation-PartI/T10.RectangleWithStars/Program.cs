using System;

namespace T10.RectangleWithStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('%', n * 2));

            for (int row = 1; row <= (n - 1) / 2; row++)
            {
                Console.Write("%");
                Console.Write(new string(' ', n * 2 - 2));
                Console.WriteLine("%");
            }

            Console.Write("%");
            Console.Write(new string(' ', (n * 2 - 4) / 2));
            Console.Write("**");
            Console.Write(new string(' ', (n * 2 - 4) / 2));
            Console.WriteLine("%");

            for (int row = 1; row <= (n - 1) / 2; row++)
            {
                Console.Write("%");
                Console.Write(new string(' ', n * 2 - 2));
                Console.WriteLine("%");
            }

            Console.WriteLine(new string('%', n * 2));
        }
    }
}
