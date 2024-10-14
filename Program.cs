using System;

class OddToEvenConverter
{
    static void Main(string[] args)
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
        if (num % 2 != 0)
        {
            return num + 1;
        }
        return num;
    }
}
