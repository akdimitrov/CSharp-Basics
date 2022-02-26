using System;

namespace T03.BullsAndCows
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int bulls = int.Parse(Console.ReadLine());
            int cows = int.Parse(Console.ReadLine());
            bool flag = true;

            for (int num1 = 1; num1 <= 9; num1++)
            {
                for (int num2 = 1; num2 <= 9; num2++)
                {
                    for (int num3 = 1; num3 <= 9; num3++)
                    {
                        for (int num4 = 1; num4 <= 9; num4++)
                        {
                            int secretNum = startNum;
                            int secretNum4 = secretNum % 10; secretNum /= 10;
                            int secretNum3 = secretNum % 10; secretNum /= 10;
                            int secretNum2 = secretNum % 10; secretNum /= 10;
                            int secretNum1 = secretNum % 10;

                            int bullsGuess = 0;
                            int cowsGuess = 0;

                            int guessNum4 = num4;
                            int guessNum3 = num3;
                            int guessNum2 = num2;
                            int guessNum1 = num1;


                            if (secretNum1 == guessNum1)
                            {
                                bullsGuess++;
                                guessNum1 = -1;
                                secretNum1 = -2;
                            }
                            if (secretNum2 == guessNum2)
                            {
                                bullsGuess++;
                                guessNum2 = -1;
                                secretNum2 = -2;
                            }
                            if (secretNum3 == guessNum3)
                            {
                                bullsGuess++;
                                guessNum3 = -1;
                                secretNum3 = -2;
                            }
                            if (secretNum4 == guessNum4)
                            {
                                bullsGuess++;
                                guessNum4 = -1;
                                secretNum4 = -2;
                            }

                            if (secretNum1 == guessNum2)
                            {
                                cowsGuess++;
                                guessNum2 = -1;
                            }
                            else if (secretNum1 == guessNum3)
                            {
                                cowsGuess++;
                                guessNum3 = -1;
                            }
                            else if (secretNum1 == guessNum4)
                            {
                                cowsGuess++;
                                guessNum4 = -1;
                            }

                            if (secretNum2 == guessNum1)
                            {
                                cowsGuess++;
                                guessNum1 = -1;
                            }
                            else if (secretNum2 == guessNum3)
                            {
                                cowsGuess++;
                                guessNum3 = -1;
                            }
                            else if (secretNum2 == guessNum4)
                            {
                                cowsGuess++;
                                guessNum4 = -1;
                            }

                            if (secretNum3 == guessNum1)
                            {
                                cowsGuess++;
                                guessNum1 = -1;
                            }
                            else if (secretNum3 == guessNum2)
                            {
                                cowsGuess++;
                                guessNum2 = -1;
                            }
                            else if (secretNum3 == guessNum4)
                            {
                                cowsGuess++;
                                guessNum4 = -1;
                            }

                            if (secretNum4 == guessNum1)
                            {
                                cowsGuess++;
                                guessNum1 = -1;
                            }
                            else if (secretNum4 == guessNum2)
                            {
                                cowsGuess++;
                                guessNum2 = -1;
                            }
                            else if (secretNum4 == guessNum3)
                            {
                                cowsGuess++;
                                guessNum3 = -1;
                            }

                            if (bulls == bullsGuess && cows == cowsGuess)
                            {
                                if (!flag)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write($"{num1}{num2}{num3}{num4}");
                                flag = false;
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
