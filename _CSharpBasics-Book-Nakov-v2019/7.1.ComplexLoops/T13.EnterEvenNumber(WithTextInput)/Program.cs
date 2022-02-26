using System;

namespace T13.EnterEvenNumber_WithTextInput_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            bool isEven = false;

            while (true)
            {
                Console.Write("Enter even number: ");
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("The number is even!");
                        isEven = true;
                        break;
                    }

                    Console.WriteLine("The number is not even!");
                }
                catch
                {
                    Console.WriteLine("Invalid input");
                }
            }

            if (isEven)
                Console.WriteLine("Even number: {0}", n);
        }
    }
}
