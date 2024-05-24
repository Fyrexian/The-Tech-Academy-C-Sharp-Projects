using System;

namespace Boolean_Logic_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("What is your age?");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?");
            bool DUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int Tickets = Convert.ToInt32(Console.ReadLine());

            bool Qualification = true;

            if (Age < 15)
                Qualification = false;

            if (DUI == true)
                Qualification = false;

            if (Tickets > 3)
                Qualification = false;


            Console.WriteLine("Qualified?");
            Console.WriteLine(Qualification);

        }
    }
}
