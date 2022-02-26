using System;

namespace T06.WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int sector1rows = int.Parse(Console.ReadLine());
            int oddRowSeats = int.Parse(Console.ReadLine());
            int counter = 0;

            for (char sector = 'A'; sector <= lastSector; sector++)
            {
                for (int row = 1; row <= sector1rows; row++)
                {
                    int seats = row % 2 == 0 ? oddRowSeats + 2 : oddRowSeats;
                    for (char seat = 'a'; seat < 'a' + seats; seat++)
                    {
                        Console.WriteLine($"{sector}{row}{seat}");
                        counter++;
                    }
                }
                sector1rows++;
            }

            Console.WriteLine(counter);
        }
    }
}
