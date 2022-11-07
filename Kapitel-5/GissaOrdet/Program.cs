using System;

namespace GissaOrdet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gissa ett ord!");

            string ordet = "Lunch";

            // Hur många ggr vill du gissa? (tal)
            Console.Write("Hur många ggr vill du gissa?: ");
            string antalFörsökString = Console.ReadLine();  // Läser in texten
            //int antalFörsök = int.Parse(antalFörsökString); // Konvertera text->tal

            // Det säkra sättet att konvertera från text till tal
            int antalFörsök = 0;
            while (!int.TryParse(antalFörsökString, out antalFörsök))
            {
                Console.Write("Du matade inte in ett heltal! Försök igen! ");
                antalFörsökString = Console.ReadLine();
            }

            // Loopa antal försök 
            for (int i = 0; i < antalFörsök; i++)
            {
                // Gissa ordet
                Console.WriteLine("Gissa ett ord: ");
                string gissning = Console.ReadLine();

                // Är det rätt?
                if (gissning == ordet)
                {
                    Console.WriteLine("Bra!");
                    break;
                }
                else
                {
                    Console.WriteLine("Fel! Försöj igen!");
                }
            }

        }
    }
}
