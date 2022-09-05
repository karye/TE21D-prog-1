using System;

namespace Labb1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Program som räknar hur mycket mer Duplantis hoppar än andra");

            // Läs in höjden i meter
            Console.Write("Ange din hopphöjd i meter: ");
            string höjdString = Console.ReadLine(); // Tex "5,5"
            
            // Konvertera till decimaltal
            double höjd = double.Parse(höjdString); // 5.5

            // Räkna ut hur mycket högre Duplantis hoppar
            double höjdSkillnad = 6.25 - höjd;

            // Skriv ut resultatet
            Console.WriteLine($"Du hoppar {höjdSkillnad} mindre än Duplantis");
        }
    }
}
