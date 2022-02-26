using System;

namespace T03.Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string action = Console.ReadLine();
            double result = 0;

            if (action == "+" || action == "-" || action == "*")
            {
                switch (action)
                {
                    case "+": result = n1 + n2; break;
                    case "-": result = n1 - n2; break;
                    case "*": result = n1 * n2; break;
                }

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} {action} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {action} {n2} = {result} - odd");
                }
            }
            else if (action == "/" || action == "%")
            {
                if (n2 != 0)
                {
                    switch (action)
                    {
                        case "/":
                            result = 1.0 * n1 / n2;
                            Console.WriteLine($"{n1} {action} {n2} = {result:f2}");
                            break;
                        case "%":
                            result = 1.0 * n1 % n2;
                            Console.WriteLine($"{n1} {action} {n2} = {result}");
                            break;
                    }
                }

                else
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
            }
        }
    }
}
