using System;

namespace T05.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int jury = int.Parse(Console.ReadLine());
            bool isNominated = false;

            for (int i = 0; i < jury; i++)
            {
                string judge = Console.ReadLine();
                double currentPoints = double.Parse(Console.ReadLine());
                points += judge.Length * currentPoints / 2;
                if (points > 1250.5)
                {
                    isNominated = true;
                    break;
                }
            }

            if (isNominated)
            {
                Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {points:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {name} you need {1250.5 - points:f1} more!");
            }
        }
    }
}
