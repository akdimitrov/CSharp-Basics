using System;

namespace T03.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int loads = int.Parse(Console.ReadLine());
            double price = 0;
            double vanLoad = 0;
            double truckLoad = 0;
            double trainLoad = 0;
            int totalWeight = 0;

            for (int i = 0; i < loads; i++)
            {
                int weight = int.Parse(Console.ReadLine());

                if (weight <= 3)
                {
                    price += weight * 200;
                    vanLoad += weight;
                }
                else if (weight <= 11)
                {
                    price += weight * 175;
                    truckLoad += weight;

                }
                else
                {
                    price += weight * 120;
                    trainLoad += weight;
                }

                totalWeight += weight;
            }

            Console.WriteLine($"{price / totalWeight:f2}");
            Console.WriteLine($"{vanLoad / totalWeight * 100.0:f2}%");
            Console.WriteLine($"{truckLoad / totalWeight * 100.0:f2}%");
            Console.WriteLine($"{trainLoad / totalWeight * 100.0:f2}%");
        }
    }
}
