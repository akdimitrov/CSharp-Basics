using System;

namespace T07.SafePasswordsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxPasswords = int.Parse(Console.ReadLine());
            char symbol1 = (char)35;
            char symbol2 = (char)64;
            int counter = 0;

            for (int symbol3 = 1; symbol3 <= a; symbol3++)
            {
                for (int symbol4 = 1; symbol4 <= b; symbol4++)
                {
                    string password = $"{symbol1}{symbol2}{symbol3}{symbol4}{symbol2}{symbol1}";
                    Console.Write(password + "|");
                    symbol1++;
                    symbol2++;
                    counter++;

                    if (symbol1 > (char)55)
                        symbol1 = (char)35;
                    if (symbol2 > (char)96)
                        symbol2 = (char)64;

                    if (counter == maxPasswords)
                    {
                        return;
                    }
                }
            }
        }
    }
}
