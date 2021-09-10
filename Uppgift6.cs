using System;

namespace IntroExercises6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej, skriv in 3 siffror du vill multiplicera tack!");

            int firstNumber = Convert.ToInt16( Console.ReadLine() ) ;
            int secondNumber = Convert.ToInt16( Console.ReadLine() ) ;
            int thirdNumber = Convert.ToInt16( Console.ReadLine() ) ;

            Console.WriteLine(firstNumber * secondNumber * thirdNumber);
        }
    }
}
