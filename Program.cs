using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Check if a number is odd or even");
        Console.WriteLine("2. Basic Calculator");
        Console.WriteLine("3. Exit");
        Console.Write("Enter your choice (1-3): ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            CheckOddEven();
        }
        else if (choice == "2")
        {
            BasicCalculator();
        }
        else if (choice == "3")
        {
            Console.WriteLine("Exiting the program. Goodbye!");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
        }
    }

    static void CheckOddEven()
    {
        Console.Write("Enter a number: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    static void BasicCalculator()
    {
        Console.Write("Enter first number: ");
        if (double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.Write("Enter second number: ");
            if (double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.Write("Enter your choice (1-4): ");
                string operation = Console.ReadLine();
                double result;

                if (operation == "1")
                {
                    result = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
                }
                else if (operation == "2")
                {
                    result = num1 - num2;
                    Console.WriteLine($"Result: {num1} - {num2} = {result}");
                }
                else if (operation == "3")
                {
                    result = num1 * num2;
                    Console.WriteLine($"Result: {num1} * {num2} = {result}");
                }
                else if (operation == "4")
                {
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Result: {num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid operation. Please select 1, 2, 3, or 4.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
