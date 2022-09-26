using System;

namespace Prov0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Var provet lätt? (j/n) ");

            // Programloop
            int försök = 0;
            while (true)
            {
                // Räknar antal gånger
                försök++;

                // Läser in svaret
                string svar = Console.ReadLine();
                
                // Kontrollera om det var rätt svar
                if (svar == "j")
                {
                    Console.WriteLine($"Bra svarat! Du klarade på {försök} försök");
                    break;
                }
                else
                {
                    Console.WriteLine("Fel svar, försök igen!");
                }

                if (försök == 5)
                {
                    Console.WriteLine("Du får inga fler försök!");
                    break;
                }
            }

        }
    }
}
