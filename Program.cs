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
                static void Main(string[] args)
                {
                    double num1, num2, result;
                    char operatorChar;

                    Console.Write("Enter the first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the operator (+, -, *, / or sqrt): ");
                    operatorChar = Console.ReadLine()[0];

                    Console.Write("Enter the second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    switch (operatorChar)
                    {
                        case '+':
                            result = num1 + num2;
                            break;
                        case '-':
                            result = num1 - num2;
                            break;
                        case '*':
                            result = num1 * num2;
                            break;
                        case '/':
                            if (num2 != 0)
                                result = num1 / num2;
                            else
                                Console.WriteLine("Error: Division by zero!");
                            return;
                            break;
                            case 's':
                            case 'S': // Square root special function
                            if (num1 >= 0)
                                result = Math.Sqrt(num1);
                            else
                                Console.WriteLine("Error: Square root of negative number!");
                            return;
                            break;
                            default:
                            Console.WriteLine("Error: Invalid operator!");
                            return;

                            Console.WriteLine("Result: {0}", result);
                            Console.WriteLine("Press Enter to continue or 'Q' to quit:");
                            string response = Console.ReadLine();
                            if (response.ToUpper() == "Q")
                            {
                                break;
                            }

                    }


                }
                     
            
            }