using System;

namespace T06.FavoriteMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int maxScore = int.MinValue;
            int counter = 0;
            string bestMovie = "";

            while (movie != "STOP")
            {
                counter++;
                int score = 0;
                for (int i = 0; i < movie.Length; i++)
                {
                    score += movie[i];
                    if (movie[i] >= 'A' && movie[i] <= 'Z')
                    {
                        score -= movie.Length;
                    }
                    else if (movie[i] >= 'a' && movie[i] <= 'z')
                    {
                        score -= movie.Length * 2;
                    }
                }

                if (score > maxScore)
                {
                    maxScore = score;
                    bestMovie = movie;
                }

                if (counter == 7)
                {
                    Console.WriteLine("The limit is reached.");
                    break;
                }

                movie = Console.ReadLine();
            }

            Console.WriteLine($"The best movie for you is {bestMovie} with {maxScore} ASCII sum.");
        }
    }
}
