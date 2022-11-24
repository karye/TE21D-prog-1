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
                /* File.WriteAllText(filnamn, tomBokning + "\n" +
                                tomBokning + "\n" +
                                tomBokning + "\n" +
                                tomBokning + "\n" +
                                tomBokning + "\n" +
                                tomBokning + "\n" +
                                tomBokning + "\n" +
                                tomBokning + "\n"
                                 ); */

                // Alternativ 2
                // Fyll arrayens alla platser med texten tombokning
                for (int i = 0; i < antalBord; i++)
                {
                    bordsInformation[i] = tomBokning;
                }
                // Spara ned hela arrayen i textfilen
                File.WriteAllLines(filnamn, bordsInformation);
                Console.WriteLine("Fil med bokningar hittades ej. Ny fil skapad.");
            }

            // Skriv ut menyn
            Console.WriteLine("\n1. Visa alla bord");
            Console.WriteLine("2. Boka bord");
            Console.WriteLine("3. Avboka bord");
            Console.WriteLine("4. Avsluta");
            Console.Write("Välj ett alternativ: ");
            string val = Console.ReadLine();

            // Hanterar användarens val
            switch (val)
            {
                case "1":
                    // Visa alla bord
                    for (int i = 0; i < antalBord; i++)
                    {
                        if (bordsInformation[i] == tomBokning)
                        {
                            // Ingen bokning
                            Console.WriteLine($"Bord {i + 1} - Inga gäster");
                        }
                        else
                        {
                            // Bokning finns
                            string rad = bordsInformation[i];

                            // Dela upp raden efter ", "
                            string[] delar = rad.Split(", ");
                            string antalGäster = delar[0];
                            string namn = delar[1];

                            Console.WriteLine($"Bord {i + 1} - Namn: {namn}, antal gäster: {antalGäster}");
                        }

                    }
                    break;

                case "2":
                    // Ändra bokning
                    break;

                case "3":
                    // Ta bort bokning
                    break;

                case "4":
                    // Avsluta
                    break;

                default:
                    Console.WriteLine("Var vänlig välj 1-4");
                    break;
            }
        }
    }
}
