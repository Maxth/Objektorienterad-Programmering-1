using System;

namespace IntroFörstaUppgiften
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej, knappa in två siffror för att dividera!");
            float firstNumber = float.Parse(Console.ReadLine());
            float secondNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("Resultatet av " + firstNumber + " dividerat med " + secondNumber + " är:" + firstNumber / secondNumber);

        }
    }
}
