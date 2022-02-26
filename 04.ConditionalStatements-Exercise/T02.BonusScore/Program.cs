using System;

namespace T02.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            double score = int.Parse(Console.ReadLine());
            double bonusScore = 0;

            if (score <= 100)
            {
                bonusScore = 5;
            }
            else if (score <= 1000)
            {
                bonusScore = score * 0.2;
            }
            else
            {
                bonusScore = score * 0.1;
            }

            if (score % 2 == 0)
            {
                bonusScore++;
            }
            else if (score % 10 == 5)
            {
                bonusScore += 2;
            }

            Console.WriteLine(bonusScore);
            Console.WriteLine(score + bonusScore);
        }
    }
}
