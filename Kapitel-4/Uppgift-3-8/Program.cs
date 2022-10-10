using System;

namespace Uppgift_3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jämför ord");

            // Läs in tre ord
            Console.WriteLine("Mata in 3 ord: ");
            string ord1 = Console.ReadLine();
            string ord2 = Console.ReadLine();
            string ord3 = Console.ReadLine();

            // Plocka första bokstaven för varje ord
            char bokstav1 = ord1[0];
            char bokstav2 = ord2[0];
            char bokstav3 = ord3[0];

            // Jämför varje bokstav
            if (bokstav1 > bokstav2)
            {
                Console.WriteLine("bokstav1 är högre än bokstav2");
            }
            else
            {
                Console.WriteLine("bokstav2 är högre är bokstav1");
            }
        }
    }
}
