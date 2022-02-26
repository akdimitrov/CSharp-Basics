using System;

namespace T05.ChallengeTheWedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int maleClients = int.Parse(Console.ReadLine());
            int femaleClients = int.Parse(Console.ReadLine());
            int totaltables = int.Parse(Console.ReadLine());

            for (int male = 1; male <= maleClients; male++)
            {
                for (int female = 1; female <= femaleClients; female++)
                {
                    if (totaltables <= 0)
                    {
                        return;
                    }
                    Console.Write($"({male} <-> {female}) ");
                    totaltables--;
                }
            }
        }
    }
}
