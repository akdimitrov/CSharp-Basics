using System;

namespace T06.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            double num2 = int.Parse(Console.ReadLine());
            string action = Console.ReadLine();
            double sum = num1;

            if (action == "+")
            {
                sum += num2;
            }
            else if (action == "-")
            {
                sum -= num2;
            }
            else if (action == "*")
            {
                sum *= num2;
            }
            else if (action == "/" && num2 != 0)
            {
                sum /= num2;
            }
            else if (action == "%" && num2 != 0)
            {
                sum %= num2;
            }

            if (action == "+" || action == "-" || action == "*")
            {
                string evenOdd = sum % 2 == 0 ? "even" : "odd";
                Console.WriteLine($"{num1} {action} {num2} = {sum} - {evenOdd}");
            }
            else if ((action == "/" || action == "%") && num2 == 0)
            {
                Console.WriteLine($"Cannot divide {num1} by zero");
            }
            else if (action == "/")
            {
                Console.WriteLine($"{num1} {action} {num2} = {sum:f2}");
            }
            else if (action == "%")
            {
                Console.WriteLine($"{num1} {action} {num2} = {sum}");
            }
        }
    }
}
