using System;

namespace mssa_5._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers to print : ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                PrintNaturalNumbers(1, n);
            }
            else
            {
                Console.WriteLine("Please enter a valid positive integer.");
            }
        }

        static void PrintNaturalNumbers(int current, int max)
        {
            if (current > max)
                return;

            Console.Write(current + (current < max ? " " : ""));
            PrintNaturalNumbers(current + 1, max);
        }
    }
}
