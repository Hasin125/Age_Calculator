using System;

namespace Age_Calculator_T
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Age Calculator \n \n");

            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("\nIn what year were you born");
            string yob = Console.ReadLine();
            int yearB = Convert.ToInt32(yob);
            int yearT = DateTime.Now.Year;

          int age  = yearT - yearB;

            Console.WriteLine($"\nDear {name} you are or will be of {age} years old this year. \n");
            Console.WriteLine("Press Any Key To Exit...");

            Console.ReadLine();
        }
    }
}
