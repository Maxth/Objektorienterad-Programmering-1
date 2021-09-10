using System;

namespace IntroExercises10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            float x = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            float y = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number:");
            float z = float.Parse(Console.ReadLine());


            Console.WriteLine("Result of specified numbers " + x + ", " + y + " and " + z +": " +
             "(" + x + " + " + y + ") * " + z + " is " + (x+y)*z + " and " + x + " x " + y + " + " + y + " x " + z + " is " + (x*y + y*z));
        }
    }
}
