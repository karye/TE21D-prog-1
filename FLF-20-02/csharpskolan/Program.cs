using System;

namespace csharpskolan
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Skapa en kod som först hämtar in ett användarnamn från användaren via Console.ReadLine.
            Gör sedan en if-sats som skriver ut "Welcome!" Ifall användarnamnet är lika med "noname". */

            Console.Write("Ange ditt användarnam: ");
            string användarnamn = Console.ReadLine();

            if (användarnamn == "noname")
            {
                Console.WriteLine("Welcome");
            }

            /* 
            Komplettera föregående kod så att både användarnamn och lösenord efterfrågas.
            "Welcome" ska skrivas ut enbart om användarnamnet är lika med "noname" och lösenordet är "nopass".
            Om någon av dem inte stämmer så ska koden skriva ut "Wrong username or password".
             */

            /* 
            Skriv en loop som skriver ut "Hello, World" 32 gånger. Välj själv om det ska vara en for-loop eller en while-loop.
             */

            for (int i = 0; i < 32; i++)
            {
                Console.WriteLine("Hej");
            }
        }
    }
}
