using System;

namespace T02.X_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            string problem = Console.ReadLine();
            decimal result = 0;
            decimal bracketsResult = 0;
            decimal num = 0;
            decimal num1 = 0;
            int counter = 0;

            for (int i = 0; i < problem.Length - 1; i += 2)
            {
                if (i == 0)
                {
                    char firstNum = problem[i];
                    if (firstNum >= 49 && firstNum <= 57)
                    {
                        result = int.Parse(firstNum.ToString());
                        i--;
                        continue;
                    }
                    else if (firstNum == '(')
                    {
                        for (int k = i + 1; k < problem.Length - 1; k += 2)
                        {
                            if (k == i + 1)
                            {
                                char firstNum1 = problem[k];
                                bracketsResult = int.Parse(firstNum1.ToString());
                                k--;
                                continue;
                            }

                            counter += 2;
                            char currentNum1 = problem[k + 1];
                            if (currentNum1 >= 49 && currentNum1 <= 57)
                            {
                                num1 = int.Parse(currentNum1.ToString());
                            }

                            char action1 = problem[k];
                            if (action1 == '+')
                            {
                                bracketsResult += num1;
                            }
                            else if (action1 == '-')
                            {
                                bracketsResult -= num1;
                            }
                            else if (action1 == '*')
                            {
                                bracketsResult *= num1;
                            }
                            else if (action1 == '/')
                            {
                                bracketsResult /= num1;
                            }
                            else if (action1 == ')')
                            {
                                counter--;
                                result = bracketsResult;
                                bracketsResult = 0;
                                i += counter;
                                counter = 0;
                                break;
                            }
                        }
                    }
                    continue;
                }

                char currentNum = problem[i + 1];
                if (currentNum >= 49 && currentNum <= 57)
                {
                    num = int.Parse(currentNum.ToString());
                }
                else if (currentNum == '(')
                {
                    for (int j = i + 2; j < problem.Length - 1; j += 2)
                    {
                        counter += 2;
                        if (j == i + 2)
                        {
                            char firstNum1 = problem[j];
                            bracketsResult = int.Parse(firstNum1.ToString());
                            j--;
                            continue;
                        }

                        char currentNum1 = problem[j + 1];
                        if (currentNum1 >= 49 && currentNum1 <= 57)
                        {
                            num1 = int.Parse(currentNum1.ToString());
                        }

                        char action1 = problem[j];
                        if (action1 == '+')
                        {
                            bracketsResult += num1;
                        }
                        else if (action1 == '-')
                        {
                            bracketsResult -= num1;
                        }
                        else if (action1 == '*')
                        {
                            bracketsResult *= num1;
                        }
                        else if (action1 == '/')
                        {
                            bracketsResult /= num1;
                        }
                        else if (action1 == ')')
                        {
                            counter -= 2;
                            num = bracketsResult;
                            bracketsResult = 0;
                            break;
                        }
                    }
                }

                char action = problem[i];
                if (action == '+')
                {
                    result += num;
                }
                else if (action == '-')
                {
                    result -= num;
                }
                else if (action == '*')
                {
                    result *= num;
                }
                else if (action == '/')
                {
                    result /= num;
                }

                if (counter > 0)
                {
                    i += counter;
                    counter = 0;
                }
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
