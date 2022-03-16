using System;

namespace T06.HighJump
{
    class Program
    {
        static void Main(string[] args)
        {
            int heightGoal = int.Parse(Console.ReadLine());
            int jumps = 0;
            int barHeight = 0;
            bool isSuccessful = true;

            for (int i = heightGoal - 30; i <= heightGoal; i += 5)
            {
                barHeight = i;
                int jumpHeight = int.Parse(Console.ReadLine());
                int counter = 1;
                jumps++;

                while (jumpHeight <= barHeight)
                {
                    if (counter == 3)
                    {
                        isSuccessful = false;
                        break;
                    }

                    jumpHeight = int.Parse(Console.ReadLine());
                    counter++;
                    jumps++;
                }

                if (!isSuccessful)
                {
                    break;
                }
            }

            if (isSuccessful)
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {barHeight}cm after {jumps} jumps.");
            }
            else
            {
                Console.WriteLine($"Tihomir failed at {barHeight}cm after {jumps} jumps.");
            }
        }
    }
}
