using System; 

namespace T03.LatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Latin alphabet:");

            for (char i = 'a'; i <= 'z'; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
