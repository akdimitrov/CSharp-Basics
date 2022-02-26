using System;

namespace T10.WeatherForecast_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp = double.Parse(Console.ReadLine());
            string output = "";

            if (temp < 5 || temp > 35)
            {
                output = "unknown";
            }
            else if (temp < 12)
            {
                output = "Cold";
            }
            else if (temp < 15)
            {
                output = "Cool";
            }
            else if (temp <= 20)
            {
                output = "Mild";
            }
            else if (temp < 26)
            {
                output = "Warm";
            }
            else
            {
                output = "Hot";
            }

            Console.WriteLine(output);
        }
    }
}
