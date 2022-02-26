using System;

namespace T05.SuitcasesLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            double trunkVolume = double.Parse(Console.ReadLine());
            int suitcases = 0;
            string input = Console.ReadLine();
            while (input != "End")
            {
                double suitcaseVolume = double.Parse(input);
                suitcases++;
                if (suitcases % 3 == 0)
                {
                    suitcaseVolume *= 1.1;
                }

                if (trunkVolume < suitcaseVolume)
                {
                    suitcases--;
                    break;
                }

                trunkVolume -= suitcaseVolume;
                input = Console.ReadLine();
            }

            if (input == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            else
            {
                Console.WriteLine("No more space!");
            }

            Console.WriteLine($"Statistic: {suitcases} suitcases loaded.");
        }
    }
}
