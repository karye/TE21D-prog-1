using System;

namespace DelaUppText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Dela i bokstäver");

            // Ange ett namn
            Console.Write("Ange ett namn: ");
            string namn = Console.ReadLine();

            // Skriv ut längden
            Console.WriteLine("Namnet är " + namn.Length + " bokstäver långt");
            
            // Skriv ut bokstav för bokstav
            for (int i = 0; i < namn.Length; i++)
            {
                Console.WriteLine(namn[i]);
            }
        }
    }
}
