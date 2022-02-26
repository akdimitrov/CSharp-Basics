using System;

namespace T03.StreamOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string word = "";
            bool cFound = false;
            bool oFound = false;
            bool nFound = false;

            while (command != "End")
            {
                char letter = char.Parse(command);

                if (letter >= 'A' && letter <= 'Z' || letter >= 'a' && letter <= 'z')
                {
                    if (letter == 'c')
                    {
                        if (cFound)
                        {
                            word += letter;
                        }
                        cFound = true;
                    }
                    else if (letter == 'o')
                    {
                        if (oFound)
                        {
                            word += letter;
                        }
                        oFound = true;
                    }
                    else if (letter == 'n')
                    {
                        if (nFound)
                        {
                            word += letter;
                        }
                        nFound = true;
                    }

                    if (cFound && oFound && nFound)
                    {
                        Console.Write(word + " ");
                        cFound = false;
                        oFound = false;
                        nFound = false;
                        word = "";
                    }
                    else if (letter != 'c' && letter != 'o' && letter != 'n')
                    {
                        word += letter;
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}
