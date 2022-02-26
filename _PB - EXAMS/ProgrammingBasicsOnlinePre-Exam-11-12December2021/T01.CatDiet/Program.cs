using System;

namespace T01.CatDiet
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatPercent = int.Parse(Console.ReadLine());
            int proteinPercent = int.Parse(Console.ReadLine());
            int carbsPercent = int.Parse(Console.ReadLine());
            double calories = int.Parse(Console.ReadLine());
            int waterPercent = int.Parse(Console.ReadLine());

            double fatGrams = fatPercent * calories / 100 / 9;
            double proteinGrams = proteinPercent * calories / 100 / 4;
            double carbsGrams = carbsPercent * calories / 100 / 4;
            double totalGrams = fatGrams + proteinGrams + carbsGrams;
            double caloriesPerGram = calories / totalGrams;
            caloriesPerGram -= waterPercent * caloriesPerGram / 100;

            Console.WriteLine($"{caloriesPerGram:f4}");
        }
    }
}
