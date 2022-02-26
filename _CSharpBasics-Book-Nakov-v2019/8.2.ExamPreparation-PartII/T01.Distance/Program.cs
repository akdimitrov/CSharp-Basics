using System;

namespace T01.Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            double startSpeed = int.Parse(Console.ReadLine());
            double firstTime = int.Parse(Console.ReadLine());
            double secondTime = int.Parse(Console.ReadLine());
            double thirdTime = int.Parse(Console.ReadLine());

            firstTime /= 60;
            secondTime /= 60;
            thirdTime /= 60;
            double secondSpeed = startSpeed * 1.1;
            double thirdSpeed = secondSpeed * 0.95;
            double firstDistance = startSpeed * firstTime;
            double secondDistance = secondSpeed * secondTime;
            double thirdDistance = thirdSpeed * thirdTime;
            double totalDistance = firstDistance + secondDistance + thirdDistance;
            Console.WriteLine($"{totalDistance:f2}");
        }
    }
}
