using System;

namespace OddToEvenCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd to Even Number Calculator");
            Console.WriteLine("-------------------------------");

            while (true)
            {
                Console.Write("Enter an odd number: ");
                int oddNumber = Convert.ToInt32(Console.ReadLine());

                // Check if the input is indeed odd
                if (oddNumber % 2 != 0)
                {
                    // Calculate the corresponding even number
                    int evenNumber = oddNumber + (2 - oddNumber % 2);

                    Console.WriteLine($"The even number corresponding to {oddNumber} is: {evenNumber}");
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter an odd number.");
                }

                Console.WriteLine("Press Enter to continue or 'Q' to quit:");
                string response = Console.ReadLine();
                if (response.ToUpper() == "Q")
                {
                    break;
                }
            }
        }
    }
}