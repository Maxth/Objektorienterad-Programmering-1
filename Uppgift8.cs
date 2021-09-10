using System;

namespace IntroExercises8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en siffra för att se dess multiplikationstabell");
            float inputNumber = float.Parse(Console.ReadLine());

            Console.WriteLine(inputNumber + " x 0 = " + (inputNumber*0) );
            Console.WriteLine(inputNumber + " x 1 = " + (inputNumber*1) );
            Console.WriteLine(inputNumber + " x 2 = " + (inputNumber*2) );
            Console.WriteLine(inputNumber + " x 3 = " + (inputNumber*3) );
            Console.WriteLine(inputNumber + " x 4 = " + (inputNumber*4) );
            Console.WriteLine(inputNumber + " x 5 = " + (inputNumber*5) );
            Console.WriteLine(inputNumber + " x 6 = " + (inputNumber*6) );
            Console.WriteLine(inputNumber + " x 7 = " + (inputNumber*7) );
            Console.WriteLine(inputNumber + " x 8 = " + (inputNumber*8) );
            Console.WriteLine(inputNumber + " x 9 = " + (inputNumber*9) );
            Console.WriteLine(inputNumber + " x 10 = " + (inputNumber*10) );
        }
    }
}
