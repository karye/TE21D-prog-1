using System;

namespace Talserier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Talserier");

            // Skriv talen 1-10 en per rad
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }

            // Skriv ut femmans tabell: 5, 10, 15, 20.. 50
            for (int i = 5; i <= 100; i += 5)
            {
                
                Console.WriteLine(i);
            }

            // Baklänges årtal 2022-1999, skriv ut varannan
            for (int i = 2022; i > 1998; i -= 2)
            {
                Console.WriteLine(i);
                
            }

        }
    }
}
