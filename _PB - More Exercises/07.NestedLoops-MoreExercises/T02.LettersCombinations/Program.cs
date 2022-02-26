using System;

namespace T02.LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char skip = char.Parse(Console.ReadLine());
            int counter = 0;

            for (char letter1 = start; letter1 <= end; letter1++)
            {
                if (letter1 == skip)
                    continue;
                for (char letter2 = start; letter2 <= end; letter2++)
                {
                    if (letter2 == skip)
                        continue;
                    for (char letter3 = start; letter3 <= end; letter3++)
                    {
                        if (letter3 == skip)
                            continue;
                        Console.Write($"{letter1}{letter2}{letter3} ");
                        counter++;
                    }
                }
            }
            Console.Write(counter);
        }
    }
}
