using System;

using KarateChopDomain;

namespace KarateChopApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+=====> Karate Chop App <=====+\n\n");
            Console.Write("Sorted array: | ");

            int[] sortedArray = { 1, 3, 5, 7, 9, 11, 13, 15 };

            foreach (var item in sortedArray)
            {
                Console.Write($"{item} | ");
            }

            Console.WriteLine("\n");

            while (true)
            {
                Console.WriteLine("Choose a target to search in the array (or Crtl + C to exit): ");
                Console.Write("=> ");

                if (int.TryParse(Console.ReadLine(), out int target))
                {
                    int result = KarateChop.Chop(target, sortedArray);

                    if (result != -1)
                        Console.WriteLine($"Target {target} found at index {result}.\n");
                    else
                        Console.WriteLine($"Target {target} not found in the array.\n");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer target to search in the array.\n\n");
                }
            }
        }
    }
}
