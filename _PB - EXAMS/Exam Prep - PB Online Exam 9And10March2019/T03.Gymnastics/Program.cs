using System;

namespace T03.Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string discipline = Console.ReadLine();
            double difficultyScore = 0;
            double performanceScore = 0;

            if (discipline == "ribbon")
            {
                switch (country)
                {
                    case "Russia": difficultyScore = 9.100; performanceScore = 9.40; break;
                    case "Bulgaria": difficultyScore = 9.600; performanceScore = 9.40; break;
                    case "Italy": difficultyScore = 9.200; performanceScore = 9.50; break;
                }
            }
            else if (discipline == "hoop")
            {
                switch (country)
                {
                    case "Russia": difficultyScore = 9.300; performanceScore = 9.80; break;
                    case "Bulgaria": difficultyScore = 9.550; performanceScore = 9.750; break;
                    case "Italy": difficultyScore = 9.450; performanceScore = 9.350; break;
                }
            }
            else if (discipline == "rope")
            {
                switch (country)
                {
                    case "Russia": difficultyScore = 9.600; performanceScore = 9.000; break;
                    case "Bulgaria": difficultyScore = 9.500; performanceScore = 9.400; break;
                    case "Italy": difficultyScore = 9.700; performanceScore = 9.150; break;
                }
            }

            double finalScore = difficultyScore + performanceScore;

            Console.WriteLine($"The team of {country} get {finalScore:f3} on {discipline}.");
            Console.WriteLine($"{100 - (finalScore * 100 / 20):f2}%");
        }
    }
}
