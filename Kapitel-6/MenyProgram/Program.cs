using System;       // Basen i C#
using System.IO;    // Filhantering

namespace MenyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Notebook appen!");

            // Programloop
            string användarensVal = "";
            while (användarensVal != "5")
            {
                // Visa menyn
                användarensVal = VisaMeny();

                // Hantera användarens val
                switch (användarensVal)
                {
                    case "1":
                        // Skriver ut alla anteckningar
                        SkriverUtAnteckningar();
                    break;

                    case "2":
                        // Fylla på med anteckningar
                        SparaAnteckning();
                    break;

                    case "3":
                        // Radera alla anteckningar
                        RaderaAnteckningar();
                    break;

                    case "4":
                        // Vänd på texten
                        VändTexten();
                    break;

                    case "5":
                        Console.WriteLine("Tack för den här gången!");
                    break;

                    default:
                        Console.WriteLine("Fel input, vg försök igen");
                    break;
                }
            }
        }

        /// <summary>
        /// Presenterar en meny, och läser in användarens val
        /// </summary>
        /// <returns>Användarens menyval</returns>
        static string VisaMeny()
        {
            Console.WriteLine("1. Skriv ut alla anteckningar");
            Console.WriteLine("2. Spara anteckning");
            Console.WriteLine("3. Avsluta");
            Console.Write("Vad vill du göra? ");
            string val = Console.ReadLine();
            return val;
        }

        /// <summary>
        /// Skriver ut alla sparade anteckningar
        /// </summary>
        static void SkriverUtAnteckningar()
        {
            string textFil = "anteckningar.txt";

            // Kontrollera att textfilen finns!
            if (File.Exists(textFil))
            {
                // Allt ok, nu läser vi
                string allaAnteckningar = File.ReadAllText(textFil);
                Console.WriteLine(allaAnteckningar);
            }
            else
            {
                Console.WriteLine("Sorry, det finns inga anteckningar!");
            }
        }

        /// <summary>
        /// Spara en anteckning i textfil
        /// </summary>
        static void SparaAnteckning()
        {
            string textFil = "anteckningar.txt";
            Console.Write("Anteckning: ");
            string anteckning = Console.ReadLine();

            // Spara i en textfil
            File.WriteAllText(textFil, anteckning);
        }

        /// <summary>
        /// Radera alla anteckningar i texfilen
        /// </summary>
        static void RaderaAnteckningar()
        {
            string textFil = "anteckningar.txt";
            File.Delete(textFil);
        }

        /// <summary>
        /// Vänder texten i anteckningar
        /// </summary>
        static void VändTexten()
        {
            string textFil = "anteckningar.txt";

            // Kontrollera att textfilen finns!
            if (File.Exists(textFil))
            {
                // Allt ok, nu läser vi
                string allaAnteckningar = File.ReadAllText(textFil);

                // Vänd på texten
                for (int i = allaAnteckningar.Length; i >= 0 ; i--)
                {    
                    Console.Write(allaAnteckningar[i]);
                }
            }
            else
            {
                Console.WriteLine("Sorry, det finns inga anteckningar!");
            }
        }
    }
}
