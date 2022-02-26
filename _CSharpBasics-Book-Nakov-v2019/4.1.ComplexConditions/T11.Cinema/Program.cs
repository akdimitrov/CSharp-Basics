using System;

namespace T11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double seats = r * c;

            switch (projection)
            {
                case "Premiere": Console.WriteLine($"{seats * 12:f2} leva"); break;
                case "Normal": Console.WriteLine($"{seats * 7.50:f2} leva"); break;
                case "Discount": Console.WriteLine($"{seats * 5:f2} leva"); break;
            }
        }
    }
}
