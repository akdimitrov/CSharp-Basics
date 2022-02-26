using System;

namespace T11.EnterEvenNumber
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
                n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    Console.WriteLine("The number is even!");
                    isEven = true;
                    break;
                }

                Console.WriteLine("The number is not even!");
            }

            if (isEven)
                Console.WriteLine("Even number: {0}", n);
        }
    }
}
