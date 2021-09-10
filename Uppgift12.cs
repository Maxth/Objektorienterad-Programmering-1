using System;

namespace IntroExercises12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en siffra");
            int siffra = Convert.ToInt16(Console.ReadLine());


                                //format string      //{0}    //{1}
            Console.WriteLine("{0} {0} {0} {0} {1}", siffra, "TEST");


            Console.WriteLine("{0}{0}{0}{0}", siffra);
            Console.WriteLine("{0} {0} {0} {0}", siffra);
            Console.WriteLine("{0}{0}{0}{0}", siffra);
        }
    }
}
