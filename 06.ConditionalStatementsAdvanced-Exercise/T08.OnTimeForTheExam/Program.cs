using System;

namespace T08.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            int examTime = examHour * 60 + examMinute;
            int arrivalTime = arrivalHour * 60 + arrivalMinute;
            int difference = examTime - arrivalTime;
            int hourDiff = Math.Abs(difference) / 60;
            int minuteDiff = Math.Abs(difference) % 60;

            if (difference < 0)
            {
                Console.WriteLine("Late");
                if (Math.Abs(difference) > 59)
                    Console.WriteLine($"{hourDiff}:{minuteDiff:d2} hours after the start");
                else
                    Console.WriteLine($"{Math.Abs(difference)} minutes after the start");
            }
            else
            {
                if (difference <= 30)
                    Console.WriteLine("On time");
                else
                    Console.WriteLine("Early");

                if (difference > 0 && difference <= 59)
                    Console.WriteLine($"{difference} minutes before the start");
                else if (difference > 59)
                    Console.WriteLine($"{hourDiff}:{minuteDiff:d2} hours before the start");
            }
        }
    }
}
