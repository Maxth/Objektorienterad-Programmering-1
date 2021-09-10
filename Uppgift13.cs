using System;

namespace IntroExercises13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en siffra!");
            int siffra = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}", siffra);
            Console.WriteLine("{0} {0}", siffra);
            Console.WriteLine("{0} {0}", siffra);
            Console.WriteLine("{0} {0}", siffra);
            Console.WriteLine("{0}{0}{0}", siffra);
        }
    }
}
