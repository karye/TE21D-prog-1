using System;

namespace Upg_5._20
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Skapa ett program där användaren får mata in så många namn som hen vill upp till ett maximalt antal av 1000. Användaren ska inte behöva bestämma hur många namn hen vill mata in i förväg, fråga i stället efter varje inmatat namn om hen vill mata in ett till namn.

            Efter att användaren har matat in alla namn så ska hen få skriva in valfritt namn, programmet ska berätta hur många gånger detta namn förekommer i listan av de tidigare inmatade namnen. */

            // Array på namn med 1000 platser
            string[] namnlista = new string[1000];

            // En inmatningsloop
            for (int i = 0; i < 1000; i++)
            {
                // Frågan
                Console.Write("Mata in ett namn: ");
                namnlista[i] = Console.ReadLine();
                
                // En till?
                Console.Write("Vill du mata in en till? (j/n) ");
                string svar = Console.ReadLine();
                if (svar == "n")
                {
                    break;
                }
            }

            // Sökdel
            Console.Write("Vad söker du för namn: ");
            string sökterm = Console.ReadLine();
            
            // Sök i namnlista efter sökterm, räkna antalet ggr
            int träffar = 0;
            foreach (var namn in namnlista)
            {
                if (namn == sökterm)
                {
                    träffar++;
                }
            }

            // Vad blev resultatet
            Console.WriteLine($"Det fanns {träffar} {sökterm} i namnlistan.");
        }
    }
}
