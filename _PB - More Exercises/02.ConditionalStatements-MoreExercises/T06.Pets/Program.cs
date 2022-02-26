using System;

namespace T06.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodleft = int.Parse(Console.ReadLine());
            double dogFoodPerDay = double.Parse(Console.ReadLine());
            double catFoodPerDay = double.Parse(Console.ReadLine());
            double turtleFoodPerDay = double.Parse(Console.ReadLine());

            turtleFoodPerDay /= 1000;
            double foodNeed = (dogFoodPerDay + catFoodPerDay + turtleFoodPerDay) * days;

            if (foodleft >= foodNeed)
            {
                Console.WriteLine($"{Math.Floor(foodleft - foodNeed)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(foodNeed - foodleft)} more kilos of food are needed.");
            }
        }
    }
}
