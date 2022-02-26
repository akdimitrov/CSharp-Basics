using System;

namespace T03.FiveSpecialLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            bool flag = true;

            for (char char1 = 'a'; char1 <= 'e'; char1++)
            {
                for (char char2 = 'a'; char2 <= 'e'; char2++)
                {
                    for (char char3 = 'a'; char3 <= 'e'; char3++)
                    {
                        for (char char4 = 'a'; char4 <= 'e'; char4++)
                        {
                            for (char char5 = 'a'; char5 <= 'e'; char5++)
                            {
                                string currentCombo = $"{char1}{char2}{char3}{char4}{char5}";

                                int weight = 0;
                                int count = 1;
                                int charCountA = 0;
                                int charCountB = 0;
                                int charCountC = 0;
                                int charCountD = 0;
                                int charCountE = 0;

                                for (int i = 0; i < currentCombo.Length; i++)
                                {
                                    char currentChar = currentCombo[i];
                                    if (currentChar == 'a')
                                    {
                                        charCountA++;
                                        if (charCountA > 1)
                                        {
                                            continue;
                                        }
                                        weight = weight + (5 * count);
                                    }
                                    else if (currentChar == 'b')
                                    {
                                        charCountB++;
                                        if (charCountB > 1)
                                        {
                                            continue;
                                        }
                                        weight = weight + (-12 * count);
                                    }
                                    else if (currentChar == 'c')
                                    {
                                        charCountC++;
                                        if (charCountC > 1)
                                        {
                                            continue;
                                        }
                                        weight = weight + (47 * count);
                                    }
                                    else if (currentChar == 'd')
                                    {
                                        charCountD++;
                                        if (charCountD > 1)
                                        {
                                            continue;
                                        }
                                        weight = weight + (7 * count);
                                    }
                                    else if (currentChar == 'e')
                                    {
                                        charCountE++;
                                        if (charCountE > 1)
                                        {
                                            continue;
                                        }
                                        weight = weight + (-32 * count);
                                    }

                                    count++;
                                }

                                if (weight >= num1 && weight <= num2)
                                {
                                    Console.Write(currentCombo + " ");
                                    flag = false;
                                }
                            }
                        }
                    }
                }
            }

            if (flag)
            {
                Console.WriteLine("No");
            }
        }
    }
}
