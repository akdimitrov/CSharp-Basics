using System;

namespace T04.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            int mount1 = 0;
            int mount2 = 0;
            int mount3 = 0;
            int mount4 = 0;
            int mount5 = 0;
            double totalPeople = 0;

            for (int i = 0; i < groups; i++)
            {
                int people = int.Parse(Console.ReadLine());
                totalPeople += people;
                if (people <= 5)
                {
                    mount1 += people;
                }
                else if (people <= 12)
                {
                    mount2 += people;
                }
                else if (people <= 25)
                {
                    mount3 += people;
                }
                else if (people <= 40)
                {
                    mount4 += people;
                }
                else
                {
                    mount5 += people;
                }
            }

            Console.WriteLine($"{mount1 / totalPeople * 100:f2}%");
            Console.WriteLine($"{mount2 / totalPeople * 100:f2}%");
            Console.WriteLine($"{mount3 / totalPeople * 100:f2}%");
            Console.WriteLine($"{mount4 / totalPeople * 100:f2}%");
            Console.WriteLine($"{mount5 / totalPeople * 100:f2}%");
        }
    }
}
