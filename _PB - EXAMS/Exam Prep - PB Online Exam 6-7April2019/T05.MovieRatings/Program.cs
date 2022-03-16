using System;

namespace T05.MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            int movies = int.Parse(Console.ReadLine());
            double maxRating = double.MinValue;
            double minRating = double.MaxValue;
            string maxMovie = "";
            string minMovie = "";
            double totalRatings = 0;

            for (int i = 0; i < movies; i++)
            {
                string movie = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());
                if (rating < minRating)
                {
                    minRating = rating;
                    minMovie = movie;
                }

                if (rating > maxRating)
                {
                    maxRating = rating;
                    maxMovie = movie;
                }

                totalRatings += rating;
            }

            Console.WriteLine($"{maxMovie} is with highest rating: {maxRating:f1}");
            Console.WriteLine($"{minMovie} is with lowest rating: {minRating:f1}");
            Console.WriteLine($"Average rating: {totalRatings / movies:f1}");
        }
    }
}
