using System;

namespace Loopar3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Skriv en loop som körs så länge användaren skriver in en string som inte kan konverteras till en int (använd All(Char.isDigit())-testet eller TryCatch / TryParse).
             */

            while (true)
            {
                Console.Write("Skriv en text: ");
                string text = Console.ReadLine();
                
                int tal = 0;
                if (int.TryParse(text, out tal))
                {
                    break;
                }
            }
        }
    }
}
