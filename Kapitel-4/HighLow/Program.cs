using System;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Gissa ett tal 1-100!");

            // Slumpa fram talet 1-100
            Random generator = new Random();
            int slumptal = generator.Next(1, 101);

            // Fråga användaren efter antal försök
            Console.Write("Hur många försök vill du ha? ");
            string maxString = Console.ReadLine();
            int max = int.Parse(maxString);

            // Loopen
            int försök = 0;
            while (true)
            {
                // Öka med 1 för varje gissning/varv
                försök++;

                // Fråga användaren om en gissning
                Console.Write("Gissa ett tal 1-100: ");
                string gissningString = Console.ReadLine();
                int gissning = int.Parse(gissningString);

                // Är det för lågt?
                if (gissning < slumptal)
                {
                    Console.WriteLine("För lågt...");   
                }
                // Är det för högt?
                else if (gissning > slumptal)
                {
                    Console.WriteLine("För lågt..");
                }
                // Är det rätt - avbryt
                else
                {
                    Console.WriteLine("Rätt svar!");
                    break;
                }

                // Avbryt när antalet försök har nått max
                if (försök == max)
                {
                    break;
                }
            }

            // Skriv ut hur många försök behövdes
            Console.WriteLine($"Bra, du behövde {försök} gissningar");
        }
    }
}
