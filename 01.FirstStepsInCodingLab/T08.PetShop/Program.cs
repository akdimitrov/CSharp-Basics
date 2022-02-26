using System;

namespace T08.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogFoodPacks = int.Parse(Console.ReadLine());
            int catFoodPacks = int.Parse(Console.ReadLine());

            double dogFoodPrice = dogFoodPacks * 2.5;
            double catFoodPrice = catFoodPacks * 4;

            Console.WriteLine($"{dogFoodPrice + catFoodPrice} lv.");
        }
    }
}
