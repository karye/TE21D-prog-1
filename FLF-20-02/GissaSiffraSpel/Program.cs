using System;

namespace GissaSiffraSpel
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Skapa ett nytt konsolprojekt GissaSiffran.
            Slumpa eller välj ett tal som användaren ska gissa.
            Skapa en loop som körs tills användaren gissat rätt.
            Du måste alltså skapa variabeln där användarens gissning lagras utanför loopen.
            Varje gång användaren gissar fel, skriv ut om gissningen var för hög eller för låg.
            Skriv ut hur många gissningar det tog för användaren att gissa rätt.
            */

            Console.WriteLine("Gissa siffran spel");

            // Slumpa eller välj ett tal som användaren ska gissa.
            Random tärning = new Random();
            int slumptal = tärning.Next(1, 7);

            Console.WriteLine($"Slumptalet är {slumptal}");
        }
    }
}
