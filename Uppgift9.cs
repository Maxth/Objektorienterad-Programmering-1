using System;

namespace IntroExercises9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in 4 siffror för att se deras medelvärde");
            float firstNumber = float.Parse(Console.ReadLine());
            float secondNumber = float.Parse(Console.ReadLine());
            float thirdNumber = float.Parse(Console.ReadLine());
            float fourthNumber = float.Parse(Console.ReadLine());

            Console.WriteLine( "The average of " + firstNumber + ", " + secondNumber + ", " + thirdNumber + ", " 
                + fourthNumber + " is:" + (firstNumber + secondNumber + thirdNumber + fourthNumber)/4 );
        }
    }
}
