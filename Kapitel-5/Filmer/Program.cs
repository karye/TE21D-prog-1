using System;

namespace Filmer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello filmer!");

            // Skapa en tom array [] med plats för 10 filmers namn
            string[] filmer = new string[10];   // 0, 1, 2, 3 ... 9

            // Fyller en array
            filmer[0] = "Star Wars";
            filmer[1] = "Star Trek";
            filmer[2] = "Star Gate";

            // Skapa en array och fyll den direkt för tvSerier
            string[] tvSerier = {
                                    "Family Guy",
                                    "Simpsons",
                                    "Grace Anatomy",
                                    "Game og Thrones"
                                };

            // Användaren fyll i resten av platserna i arrayen "filmer"
            // Tomma platser är: 3-9
/*             Console.Write("Skriv in film nr 4");
            filmer[3] = Console.ReadLine();
            Console.Write("Skriv in film nr 5");
            filmer[4] = Console.ReadLine();
            Console.Write("Skriv in film nr 6");
            filmer[5] = Console.ReadLine();
            Console.Write("Skriv in film nr 7");
            filmer[6] = Console.ReadLine();
            Console.Write("Skriv in film nr 8");
            filmer[7] = Console.ReadLine();
            Console.Write("Skriv in film nr 9");
            filmer[8] = Console.ReadLine();
            Console.Write("Skriv in film nr 10");
            filmer[9] = Console.ReadLine(); */

            // Loopa 3-9
            for (int i = 3; i < 10; i++)
            {
                Console.Write($"Skriv in film nr {i + 1}");
                filmer[i] = Console.ReadLine();
            }
            
            // Skriv ut hela arrayen rad-för-rad
            foreach (var film in filmer)
            {
                Console.WriteLine(film);
            }
        }
    }
}
