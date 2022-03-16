using System;

namespace T06.TheMostPowerfulWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxPower = int.MinValue;
            string maxWord = "";

            string word = Console.ReadLine();
            while (word != "End of words")
            {
                int power = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    power += word[i];
                }

                bool condition1 = word[0] == 'A' || word[0] == 'E' || word[0] == 'I' || word[0] == 'O' || word[0] == 'U' || word[0] == 'Y';
                bool condition2 = word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'o' || word[0] == 'u' || word[0] == 'y';
                if (condition1 || condition2)
                {
                    power *= word.Length;
                }
                else
                {
                    power = power / word.Length;
                }

                if (power > maxPower)
                {
                    maxPower = power;
                    maxWord = word;
                }

                word = Console.ReadLine();
            }

            Console.WriteLine($"The most powerful word is {maxWord} - {maxPower}");
        }
    }
}
