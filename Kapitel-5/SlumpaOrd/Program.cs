using System;

namespace SlumpaOrd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gissa ett ord!");

            // Skapa en samling av ord
            string[] orden = {"ko", "fisk", "älg", "häst", "hund"};

            // En slumptalsgenerator
            Random generator = new Random();

            // Slumpa fram en position 0-4
            int index = generator.Next(0, 5);
            Console.WriteLine($"Index blev {index}");

            // Slumpade ordet
            Console.WriteLine($"Det slumpade ordet blir då {orden[index]}");
        }
    }
}
