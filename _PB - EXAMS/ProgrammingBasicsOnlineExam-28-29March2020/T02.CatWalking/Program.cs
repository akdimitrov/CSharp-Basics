using System;

namespace T02.CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            int walks = int.Parse(Console.ReadLine());
            int calories = int.Parse(Console.ReadLine());

            int burntCalories = minutes * walks * 5;
            if (burntCalories >= calories / 2)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burntCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burntCalories}.");
            }
        }
    }
}
