using System;

namespace T02.EasterGuests
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double breads = Math.Ceiling(guests / 3.0);
            double eggs = guests * 2;
            double totalPrice = eggs * 0.45 + breads * 4;

            if (totalPrice <= budget)
            {
                Console.WriteLine($"Lyubo bought {breads} Easter bread and {eggs} eggs.");
                Console.WriteLine($"He has {budget - totalPrice:f2} lv. left.");
            }
            else
            {
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {totalPrice - budget:f2} lv. more.");
            }
        }
    }
}
