using System;

namespace T01.BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());
            double cake = rent * 0.20;
            double drinks = cake * 0.55;
            double animator = rent / 3;
            double total = cake + drinks + animator + rent;

            Console.WriteLine(total);
        }
    }
}
