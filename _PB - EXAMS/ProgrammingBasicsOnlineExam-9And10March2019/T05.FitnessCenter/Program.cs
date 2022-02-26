﻿using System;

namespace T05.FitnessCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            int visitors = int.Parse(Console.ReadLine());
            int back = 0;
            int chest = 0;
            int legs = 0;
            int abs = 0;
            int proteinShake = 0;
            int proteinBar = 0;

            for (int i = 0; i < visitors; i++)
            {
                string activity = Console.ReadLine();
                switch (activity)
                {
                    case "Back": back++; break;
                    case "Chest": chest++; break;
                    case "Legs": legs++; break;
                    case "Abs": abs++; break;
                    case "Protein shake": proteinShake++; break;
                    case "Protein bar": proteinBar++; break;
                }
            }

            double trainingPeople = back + chest + legs + abs;
            double shoppingPeople = proteinBar + proteinShake;

            Console.WriteLine($"{back} - back");
            Console.WriteLine($"{chest} - chest");
            Console.WriteLine($"{legs} - legs");
            Console.WriteLine($"{abs} - abs");
            Console.WriteLine($"{proteinShake} - protein shake");
            Console.WriteLine($"{proteinBar} - protein bar");
            Console.WriteLine($"{trainingPeople / visitors * 100:f2}% - work out");
            Console.WriteLine($"{shoppingPeople / visitors * 100:f2}% - protein");
        }
    }
}
