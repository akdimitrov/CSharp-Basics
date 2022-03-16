using System;

namespace T04.Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int percentNotToBePainted = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double area = height * width * 4;
            area -= area * (percentNotToBePainted / 100.0);
            area = Math.Ceiling(area);

            while (input != "Tired!")
            {
                int paintLitres = int.Parse(input);
                area -= paintLitres;
                if (area <= 0)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            if (input == "Tired!")
            {
                Console.WriteLine($"{area} quadratic m left.");
            }
            else if (area == 0)
            {
                Console.WriteLine("All walls are painted! Great job, Pesho!");
            }
            else
            {
                Console.WriteLine($"All walls are painted and you have {Math.Abs(area)} l paint left!");
            }
        }
    }
}
