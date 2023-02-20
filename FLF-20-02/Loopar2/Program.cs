using System;

namespace Loopar2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Skriv en loop som körs 5 gånger. Varje gång loopen körs ska användaren skriva in ett tal.
            Om talet är högre än 5, skriv ut “högre än 5!”.
            Observera att du måste konvertera talet från en string till en int för att kunna göra jämförelsen.
             */

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ange ett tal: ");
                int tal = int.Parse(Console.ReadLine());

                // Om talet är prick 99, skriv ut "hejdå!" och avsluta
                
            }
        }
    }
}
