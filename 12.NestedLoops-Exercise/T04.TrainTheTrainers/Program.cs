using System;

namespace T04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();
            double averageGradeSum = 0;
            int presentations = 0;

            while (presentation != "Finish")
            {
                presentations++;
                double averageGrade = 0;

                for (int i = 0; i < n; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    averageGrade += grade;
                }

                averageGrade /= n;
                averageGradeSum += averageGrade;
                Console.WriteLine($"{presentation} - {averageGrade:f2}.");
                presentation = Console.ReadLine();
            }

            Console.WriteLine($"Student's final assessment is {averageGradeSum / presentations:f2}.");
        }
    }
}
