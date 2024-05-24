using System;

namespace MATH_AND_COMPARISON
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");

            Console.WriteLine("Hourly Rate");
            int P1_Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week");
            int P1_Hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");

            Console.WriteLine("Hourly Rate");
            int P2_Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week");
            int P2_Hours = Convert.ToInt32(Console.ReadLine());

            int P1_Annual = P1_Rate * P1_Hours * 12;
            int P2_Annual = P2_Rate * P2_Hours * 12;

            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(P1_Annual);
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(P1_Annual);
            Console.WriteLine("Does Person 1 make more money than Person 2 ?");
            Console.WriteLine(P1_Annual>P2_Annual);

        }
    }
}
