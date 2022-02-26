using System;

namespace T09.VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int volewsSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'a': volewsSum += 1; break;
                    case 'e': volewsSum += 2; break;
                    case 'i': volewsSum += 3; break;
                    case 'o': volewsSum += 4; break;
                    case 'u': volewsSum += 5; break;
                }
            }

            Console.WriteLine(volewsSum);
        }
    }
}
