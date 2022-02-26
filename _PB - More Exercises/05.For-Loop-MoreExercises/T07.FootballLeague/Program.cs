using System;

namespace T07.FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int totalFans = int.Parse(Console.ReadLine());
            double fans = 0;
            double sectorA = 0;
            double sectorB = 0;
            double sectorV = 0;
            double sectorG = 0;

            for (int i = 0; i < totalFans; i++)
            {
                string sector = Console.ReadLine();
                fans++;

                if (sector == "A")
                    sectorA++;
                else if (sector == "B")
                    sectorB++;
                else if (sector == "V")
                    sectorV++;
                else if (sector == "G")
                    sectorG++;
            }

            Console.WriteLine($"{sectorA / totalFans * 100:f2}%");
            Console.WriteLine($"{sectorB / totalFans * 100:f2}%");
            Console.WriteLine($"{sectorV / totalFans * 100:f2}%");
            Console.WriteLine($"{sectorG / totalFans * 100:f2}%");
            Console.WriteLine($"{fans / capacity * 100:f2}%");
        }
    }
}
