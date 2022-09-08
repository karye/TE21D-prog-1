using System;

namespace Labb2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Program för att räkna ut din BMI");

            // Läs in vikt i kg
            Console.Write("Hur mycket väger du? (kg) ");
            string viktString = Console.ReadLine();
            double vikt = double.Parse(viktString);

            // Läs in längd i meter
            Console.Write("Hur lång är du? (m) ");
            string längdString = Console.ReadLine();
            double längd = double.Parse(längdString);

            // Räkna ut BMI
            double bmi = vikt / (längd * längd);

            // Skriv ut resultatet
            Console.WriteLine($"Din bmi är {bmi}");
        }
    }
}
