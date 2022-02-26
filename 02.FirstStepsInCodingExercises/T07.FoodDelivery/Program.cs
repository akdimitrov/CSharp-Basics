using System;

namespace T07.FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMeals = int.Parse(Console.ReadLine());
            int fishMeals = int.Parse(Console.ReadLine());
            int veggieMeals = int.Parse(Console.ReadLine());

            double chickenMealsPrice = chickenMeals * 10.35;
            double fishMealsPrice = fishMeals * 12.40;
            double veggieMealsPrice = veggieMeals * 8.15;
            double totalMealsPrice = chickenMealsPrice + fishMealsPrice + veggieMealsPrice;
            double dessertPrice = totalMealsPrice * 0.2;
            double finalSum = totalMealsPrice + dessertPrice + 2.50;

            Console.WriteLine(finalSum);
        }
    }
}
