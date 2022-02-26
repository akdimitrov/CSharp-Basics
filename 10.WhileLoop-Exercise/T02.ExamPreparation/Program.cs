using System;

namespace T02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            string problem = Console.ReadLine();
            double gradesSum = 0;
            int problems = 0;
            int fails = 0;
            string lastProblem = "";

            while (problem != "Enough" && badGrades != fails)
            {
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    fails++;
                }

                gradesSum += grade;
                problems++;
                lastProblem = problem;
                problem = Console.ReadLine();
            }

            if (problem == "Enough")
            {
                Console.WriteLine($"Average score: {gradesSum / problems:f2}");
                Console.WriteLine($"Number of problems: {problems}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            else
            {
                Console.WriteLine($"You need a break, {fails} poor grades.");
            }
        }
    }
}
