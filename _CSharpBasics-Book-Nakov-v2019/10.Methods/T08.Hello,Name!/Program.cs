using System;

namespace T08.Hello_Name_
{
    class Program
    {
        static void GreetingByName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            GreetingByName(name);
        }
    }
}
