using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // One-dimensional Array of strings
        string[] stringArray = new string[] { "Left", "Middle", "Right" };

        Console.WriteLine("Select an index of the Array:");
        int stringIndex = Convert.ToInt32(Console.ReadLine());

        if (stringIndex >= 0 && stringIndex < stringArray.Length)
        {
            Console.WriteLine("String at index {0}: {1}", stringIndex, stringArray[stringIndex]);
        }
        else
        {
            Console.WriteLine("Invalid index selected.");
        }

        // One-dimensional Array of integers
        int[] intArray = new int[] { 10, 20, 30 };

        Console.WriteLine("Select an index of the Array:");
        int intIndex = Convert.ToInt32(Console.ReadLine());

        if (intIndex >= 0 && intIndex < intArray.Length)
        {
            Console.WriteLine("Integer at index {0}: {1}", intIndex, intArray[intIndex]);
        }
        else
        {
            Console.WriteLine("Invalid index selected.");
        }

        // List of strings
        List<string> stringList = new List<string> { "Cat", "Dog", "Elephant" };

        Console.WriteLine("Select an index of the List:");
        int listIndex = Convert.ToInt32(Console.ReadLine());

        if (listIndex >= 0 && listIndex < stringList.Count)
        {
            Console.WriteLine("Content at index {0}: {1}", listIndex, stringList[listIndex]);
        }
        else
        {
            Console.WriteLine("Invalid index selected.");
        }
    }
}
