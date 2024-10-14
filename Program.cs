using System;

namespace OddToEvenConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Odd to Even Converter!");

            // Read input from the user
            Console.Write("Please enter an integer: ");
            string input = Console.ReadLine();

            // Try to parse the input
            if (int.TryParse(input, out int number))
            {
                // Check if the number is odd
                if (number % 2 != 0)
                {
                    // Convert odd to even
                    number += 1; // Increment to make it even
                    Console.WriteLine($"Converted odd number to even: {number}");
                }
                else
                {
                    Console.WriteLine($"The number is already even: {number}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            // Wait for user to press a key before closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
