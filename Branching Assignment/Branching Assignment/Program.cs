using System;

namespace Branching_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            int Weight = Convert.ToInt32(Console.ReadLine());
            if (Weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day.");
                System.Environment.Exit(1);
            }

            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            if (width+length+height > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                System.Environment.Exit(1);
            }

            float total = ((width * height * length) * Weight / 100);
            Console.WriteLine("Your estimated total for shipping this package is: $" + total);
            Console.WriteLine("Thank you!");
        }
    }
}
