using System;

namespace Sporter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mina sporter!");

            //  Fråga först användaren hur många sporter hen vill skriva in.
            Console.Write("Hur många sporter tränar du? ");
            int antalSporter = int.Parse(Console.ReadLine());

            // Skapa en tom array för alla sporter (text = string), tex "Bandy"
            string[] sporter = new string[antalSporter];

            // Därefter ska sporterna skrivas in, en efter en, på var sin rad.
            for (int i = 0; i < sporter.Length; i++)
            {
                Console.Write($"Ange sport nr {i + 1}: ");
                sporter[i] = Console.ReadLine();
            }

            // Slutligen ska programmet skriva ut namnen på alla sporterna som användaren skrev in.
            foreach (var sport in sporter)
            {
                Console.WriteLine(sport);
            }
        }
    }
}
