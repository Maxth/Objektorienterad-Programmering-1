using System;

namespace IntroExercises7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in två siffror");
            int firstNumber = Convert.ToInt16(Console.ReadLine());
            int secondNumber = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(firstNumber + " + " + secondNumber + " = " + (firstNumber + secondNumber));
            Console.WriteLine(firstNumber + " - " + secondNumber + " = " + (firstNumber - secondNumber));
            Console.WriteLine(firstNumber + " x " + secondNumber + " = " + (firstNumber * secondNumber));
            Console.WriteLine(firstNumber + " / " + secondNumber + " = " + (firstNumber / secondNumber));
            Console.WriteLine(firstNumber + " mod " + secondNumber + " = " + (firstNumber % secondNumber));
        }
    }
}
