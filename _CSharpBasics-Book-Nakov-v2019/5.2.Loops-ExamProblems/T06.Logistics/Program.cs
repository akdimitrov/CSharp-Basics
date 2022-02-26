using System;

namespace T06.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int parcels = int.Parse(Console.ReadLine());
            int vanLoad = 0;
            int truckLoad = 0;
            int trainLoad = 0;
            double vanPrice = 0;
            double truckPrice = 0;
            double trainPrice = 0;
            int totalWeight = 0;

            for (int i = 0; i < parcels; i++)
            {
                int weight = int.Parse(Console.ReadLine());

                if (weight <= 3)
                {
                    vanLoad += weight;
                    vanPrice += weight * 200;
                }
                else if (weight <= 11)
                {
                    truckLoad += weight;
                    truckPrice += weight * 175;
                }
                else
                {
                    trainLoad += weight;
                    trainPrice += weight * 120;
                }

                totalWeight += weight;
            }

            double averagePrice = (vanPrice + truckPrice + trainPrice) / totalWeight;

            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{1.0 * vanLoad / totalWeight * 100:f2}%");
            Console.WriteLine($"{1.0 * truckLoad / totalWeight * 100:f2}%");
            Console.WriteLine($"{1.0 * trainLoad / totalWeight * 100:f2}%");

        }
    }
}
