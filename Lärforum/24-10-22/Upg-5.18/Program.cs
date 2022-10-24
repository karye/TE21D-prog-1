/* 
Skapa ett program som skriver som sparar världens fem folkrikaste länder och sedan skriver ut dem till användaren på detta sätt:

1. Kina
2. Indien
3. USA
4. Indonesien
5. Pakistan
 */
using System;

namespace Upg_5._18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uppgift 5.18!");

            // Array med 5 länder
            string[] länder = {"Kina", "Indien", "USA", "Indonesien", "Pakistan"};

            // Skriv numrerade 1-5
            for (int i = 0; i < länder.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {länder[i]}");
            }

            /* 
            Be därefter användaren att mata in de länder som ska visas igen genom att skriva 
            deras nummer på en rad separerat av mellanslag, t.ex. 1 3 5. 
            Därefter ska programmet visa de länder som användaren valde en gång till. 
            Med de exempelnummer vi valde ska programmet skriva:
            1. Kina
            3. USA
            5. Pakistan
             */

            Console.Write("Ange länder att skriva ut separera med mellanslag: ");
            string angivnaLänder = Console.ReadLine();
            
            // Splitta texten längs med mellanslag
            string[] nummerLista = angivnaLänder.Split(' ');     // ["1", "3", "5"]
            
            // Loopar igenom nummerLista
            foreach (var nummer in nummerLista)
            {
                Console.WriteLine($"{nummer}: {länder[int.Parse(nummer) - 1]}");
            }
        }
    }
}
