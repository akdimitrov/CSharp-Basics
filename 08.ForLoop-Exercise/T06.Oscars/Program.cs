using System;

namespace T06.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int jury = int.Parse(Console.ReadLine());

            for (int i = 0; i < jury; i++)
            {
                string judge = Console.ReadLine();
                double judgePoints = double.Parse(Console.ReadLine());
                points += judge.Length * judgePoints / 2;

                if (points >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {points:f1}!");
                    break;
                }
            }

            if (points < 1250.5)
            {
                Console.WriteLine($"Sorry, {name} you need {1250.5 - points:f1} more!");
            }
        }
    }
}
