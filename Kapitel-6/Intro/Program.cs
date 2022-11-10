using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SkrivUtKvadrat(9);
        }

        // EN metod för att skriva ut kvadraten
        static void SkrivUtKvadrat(int tal)
        {
            Console.WriteLine($"Kvadraten på {tal} är {tal * tal}");
        }

        // Metod som visar en meny
        static void VisaMeny()
        {
            Console.WriteLine("1. Räkna ut kvadraten");
            Console.WriteLine("2. Räkna ut Kuben");
            Console.WriteLine("3. Avsluta programmet");
        }
    }
}
