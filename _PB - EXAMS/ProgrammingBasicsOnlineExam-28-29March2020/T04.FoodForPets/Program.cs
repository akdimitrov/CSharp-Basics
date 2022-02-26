using System;

namespace T04.FoodForPets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double totalFood = double.Parse(Console.ReadLine());
            int dogFood = 0;
            int catFood = 0;
            double biscuits = 0;

            for (int i = 1; i <= days; i++)
            {
                int dailyDogFood = int.Parse(Console.ReadLine());
                int dailyCatFood = int.Parse(Console.ReadLine());
                dogFood += dailyDogFood;
                catFood += dailyCatFood;
                if (i % 3 == 0)
                {
                    biscuits += (dailyCatFood + dailyDogFood) * 0.1;
                }
            }

            double eatenFood = dogFood + catFood;
            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
            Console.WriteLine($"{eatenFood / totalFood * 100:f2}% of the food has been eaten.");
            Console.WriteLine($"{dogFood / eatenFood * 100:f2}% eaten from the dog.");
            Console.WriteLine($"{catFood / eatenFood * 100:f2}% eaten from the cat.");

        }
    }
}
