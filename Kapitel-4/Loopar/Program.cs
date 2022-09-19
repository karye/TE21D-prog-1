using System;

namespace Loopar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Den oändliga loopen!");

            // Loopen
            while (true)
            {
                Console.WriteLine("När blir prov 1 i programmering? ");
                string svar = Console.ReadLine();
                
                // Avbryt när svaret är korrekt
                if (svar == "26")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Fel svar");
                }
            }
        }
    }
}
