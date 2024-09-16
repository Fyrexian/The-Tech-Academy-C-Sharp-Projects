using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        Console.Write("Enter a number to divide each number in the list by: ");
        string input = Console.ReadLine();

        try
        {
            int divisor = int.Parse(input);

            foreach (int number in numbers)
            {
                int result = number / divisor;
                Console.WriteLine($"Result: {result}");
            }
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter a valid number.");
        }

        Console.WriteLine("Program execution continued after the try/catch block.");
    }
}
