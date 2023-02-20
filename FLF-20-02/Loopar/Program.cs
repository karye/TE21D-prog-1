using System;

namespace Loopar
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Skriv en loop som fortsätter så länge användaren inte har skrivit in rätt lösenord.
            Du måste alltså lägga in din Console.ReadLine() inuti en while-loop.
             */

            while (true)
            {
                Console.Write("Var är ditt lösenord? ");
                string lösenord = Console.ReadLine();
                
                if (lösenord == "nopass")
                {
                    Console.WriteLine("Välkommen!");
                    break;
                }
                else
                {
                    Console.WriteLine("Försök igen!");
                }
            }
        }
    }
}
