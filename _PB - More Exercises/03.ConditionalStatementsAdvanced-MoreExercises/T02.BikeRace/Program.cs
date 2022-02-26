using System;

namespace T02.BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string route = Console.ReadLine();
            double juniorFee = 0;
            double seniorFee = 0;

            if (route == "trail")
            {
                juniorFee = juniors * 5.50;
                seniorFee = seniors * 7;
            }
            else if (route == "cross-country")
            {
                juniorFee = juniors * 8;
                seniorFee = seniors * 9.50;

                if (seniors + juniors >= 50)
                {
                    juniorFee = juniors * (8 * 0.75);
                    seniorFee = seniors * (9.50 * 0.75);
                }
            }
            else if (route == "downhill")
            {
                juniorFee = juniors * 12.25;
                seniorFee = seniors * 13.75;
            }
            else if (route == "road")
            {
                juniorFee = juniors * 20;
                seniorFee = seniors * 21.50;
            }

            double totalMoney = (juniorFee + seniorFee) * 0.95;
            Console.WriteLine($"{totalMoney:f2}");
        }
    }
}
