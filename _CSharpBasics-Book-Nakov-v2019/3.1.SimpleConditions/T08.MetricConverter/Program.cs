using System;

namespace T08.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine().ToLower();
            string outputUnit = Console.ReadLine().ToLower();

            if (inputUnit == "m")
            {
                distance = distance;
            }
            else if (inputUnit == "mm")
            {
                distance /= 1000;
            }
            else if (inputUnit == "cm")
            {
                distance /= 100;
            }
            else if (inputUnit == "mi")
            {
                distance /= 0.000621371192;
            }
            else if (inputUnit == "in")
            {
                distance /= 39.3700787;
            }
            else if (inputUnit == "km")
            {
                distance /= 0.001;
            }
            else if (inputUnit == "ft")
            {
                distance /= 3.2808399;
            }
            else if (inputUnit == "yd")
            {
                distance /= 1.0936133;
            }

            if (outputUnit == "m")
            {
                distance = distance;
            }
            else if (outputUnit == "mm")
            {
                distance *= 1000;
            }
            else if (outputUnit == "cm")
            {
                distance *= 100;
            }
            else if (outputUnit == "mi")
            {
                distance *= 0.000621371192;
            }
            else if (outputUnit == "in")
            {
                distance *= 39.3700787;
            }
            else if (outputUnit == "km")
            {
                distance *= 0.001;
            }
            else if (outputUnit == "ft")
            {
                distance *= 3.2808399;
            }
            else if (outputUnit == "yd")
            {
                distance *= 1.0936133;
            }

            Console.WriteLine(distance);
        }
    }
}
