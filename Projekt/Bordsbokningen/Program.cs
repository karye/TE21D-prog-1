using System;
using System.IO;

namespace Bordsbokningen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initiera några variabler
            string filnamn = "centralbord.csv";
            string tomBokning = "0, Inga gäster";
            int antalBord = 8;

            // Skapa array för att lagra bokningar
            string[] bordsInformation = new string[antalBord];

            // Information om programmet
            Console.WriteLine("Välkommen till Centralrestaurangens bordshanterare!");

            // Läs från textfilen och lagra i aen array
            if (File.Exists(filnamn))
            {
                bordsInformation = File.ReadAllLines(filnamn);
            }
            else
            {
                // Fyll filen med 8 tomma bord
                // Alternativ 1
                File.WriteAllText(filnamn, tomBokning + "\n" +
                                tomBokning + "\n" +
                                tomBokning + "\n" +
                                tomBokning + "\n" +
                                tomBokning + "\n" +
                                tomBokning + "\n" +
                                tomBokning + "\n" +
                                tomBokning + "\n"
                                 );
            }

            // Skriv ut menyn
            Console.WriteLine("\n1. Visa alla bord");
            Console.WriteLine("2. Boka bord");
            Console.WriteLine("3. Avboka bord");
            Console.WriteLine("4. Avsluta");
            Console.Write("Välj ett alternativ: ");
            string val = Console.ReadLine();
            
        }
    }
}
