using System;

namespace IntroExercises11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in din ålder");
            int ålder = Convert.ToInt16 ( Console.ReadLine() );
            Console.WriteLine("Du ser äldre ut än " + ålder);
        }
    }
}
