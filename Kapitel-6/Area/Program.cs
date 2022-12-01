using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Räkna ut arean!");

            // Ange längden
            Console.Write("Ange längd: ");
            int längd = int.Parse(Console.ReadLine());
            Console.Write("Ange bredd: ");
            int bredd = int.Parse(Console.ReadLine());

            int area = RäknaUtArean(längd, bredd);
            Console.WriteLine($"Arean är {area}");

            // Anropa metoden
            Console.WriteLine(AntalBokstäver("Milton"));
            Console.WriteLine(AntalVokaler("Milton"));

            int gissning = LäsInHeltal();
        }

        // En metod för att räkna ut area (func)
        static int RäknaUtArean(int längden, int bredden)
        {
            return längden * bredden;
        }

        // Skapa en metod som tar emot ett ord och returnerar antalet bokstäver i ordet
        static int AntalBokstäver(string ord)
        {
            return ord.Length;
        }

        // Skapa en metod som tar emot ett ord och returnerar antalet vokaler i ordet
        // Vokaler = A, O, E, U, I, Å, Ä, Ö
        static int AntalVokaler(string ord)
        {
            int antal = 0;
            for (int i = 0; i < ord.Length; i++)
            {
                // Alt 1
                /* if (ord[i] == 'a' || ord[i] == 'o' || ord[i] == 'e' || 
                    ord[i] == 'u' || ord[i] == 'i' || ord[i] == 'å' ||
                    ord[i] == 'ä' || ord[i] == 'ö' )
                {
                    antal++;
                } */

                // Alt 2
                if ("aeoiuåäö".Contains(ord[i]))
                {
                    antal++;
                }
            }
            return antal;
        }

        // Skapa en metod som tar emot ett text och returnerar antalet siffror i texten
        // Tips: använd Char.IsDigit('a') för att kolla om ett tecken är en siffra.
        static int AntalSiffror(string texten)
        {
            int antal = 0;
            foreach (char bokstav in texten)
            {
                if (Char.IsDigit(bokstav))
                {
                    antal++;
                }
            }
            return antal;
        }

        // Skapa en metod som tar emot en text och returnerar antalet ord i texten
        // .Split()
        static int AntalOrd(string texten)
        {
            return texten.Split(" ").Length;
        }

        // En metod för säker inmatning av heltal
        static int LäsInHeltal()
        {
            Console.WriteLine("Ange ett heltal: ");

            int heltal = 0;
            while (!int.TryParse(Console.ReadLine(), out heltal))
            {
                Console.WriteLine("Ange ett heltal: ");
            }
            return heltal;
        }

        // Samma med valfri fråga
        static int LäsInHeltal(string fråga)
        {
            Console.WriteLine(fråga);

            int heltal = 0;
            while (!int.TryParse(Console.ReadLine(), out heltal))
            {
                Console.WriteLine(fråga);
            }
            return heltal;
        }
    }
}
