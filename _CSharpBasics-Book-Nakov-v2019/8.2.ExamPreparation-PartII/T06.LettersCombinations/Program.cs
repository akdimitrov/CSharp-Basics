using System;

namespace T06.LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char lastLetter = char.Parse(Console.ReadLine());
            char ignoreLetter = char.Parse(Console.ReadLine());
            int count = 0;

            for (char first = firstLetter; first <= lastLetter; first++)
            {
                for (char second = firstLetter; second <= lastLetter; second++)
                {
                    for (char third = firstLetter; third <= lastLetter; third++)
                    {
                        if (first != ignoreLetter && second != ignoreLetter && third != ignoreLetter)
                        {
                            Console.Write($"{first}{second}{third} ");
                            count++;
                        }
                    }
                }
            }

            Console.Write(count);
        }
    }
}
