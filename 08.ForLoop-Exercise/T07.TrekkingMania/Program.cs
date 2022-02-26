using System;

namespace T07.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            double totalParticipants = 0;

            for (int i = 0; i < groups; i++)
            {
                int participants = int.Parse(Console.ReadLine());
                totalParticipants += participants;

                if (participants <= 5)
                    p1 += participants;
                else if (participants <= 12)
                    p2 += participants;
                else if (participants <= 25)
                    p3 += participants;
                else if (participants <= 40)
                    p4 += participants;
                else
                    p5 += participants;
            }

            Console.WriteLine($"{p1 / totalParticipants * 100:f2}%");
            Console.WriteLine($"{p2 / totalParticipants * 100:f2}%");
            Console.WriteLine($"{p3 / totalParticipants * 100:f2}%");
            Console.WriteLine($"{p4 / totalParticipants * 100:f2}%");
            Console.WriteLine($"{p5 / totalParticipants * 100:f2}%");
        }
    }
}
