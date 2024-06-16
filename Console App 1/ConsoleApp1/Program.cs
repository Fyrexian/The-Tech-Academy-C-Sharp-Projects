using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of strings with at least two identical strings
        List<string> stringsList = new List<string> { "moon", "sun", "destiny", "gods", "sun" };

        // Ask the user to input some text
        Console.WriteLine("Enter some text:");
        string userInput = Console.ReadLine();

        // Initialize a variable to keep track of whether a match has been found
        bool matchFound = false;

        // Loop through each string in the list and check for a match
        for (int i = 0; i < stringsList.Count; i++)
        {
            if (stringsList[i] == userInput)
            {
                // Display the index of the matching string
                Console.WriteLine($"Match found at index {i}");
                matchFound = true;
                break; // Stop the loop once a match has been found
            }
        }

        // If no match was found, display a message
        if (!matchFound)
        {
            Console.WriteLine("No match found");
        }

        // Create a HashSet to track unique strings
        HashSet<string> seenStrings = new HashSet<string>();

        // Evaluate each item in the list
        foreach (var str in stringsList)
        {
            // Display a message showing the string and whether or not it has already appeared in the list
            if (!seenStrings.Add(str)) // Add returns false if the item was already in the set
            {
                Console.WriteLine($"{str} has already appeared in the list.");
            }
            else
            {
                Console.WriteLine($"{str} has not appeared in the list before.");
            }
        }
    }
}