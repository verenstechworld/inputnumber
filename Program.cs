using System;

class OddToEvenConverter
{
    static void Main(string[] args)
    {
        RunConverter();
    }

    static void RunConverter()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Odd to Even Converter\n");
            Console.Write("Enter a number: ");

            if (int.TryParse(Console.ReadLine(), out int number))
            {
                int converted = ConvertOddToEven(number);
                Console.WriteLine($"\n{number} has been converted to {converted}\n");
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please enter a valid integer.\n");
            }

            Console.Write("Do you want to convert another number? (y/n): ");
            if (Console.ReadKey().Key != ConsoleKey.Y)
            {
                break;
            }
        }
    }

    static int ConvertOddToEven(int num)
    {
        return (num % 2 != 0) ? num + 1 : num; // Using a ternary operator for conciseness
    }
}
