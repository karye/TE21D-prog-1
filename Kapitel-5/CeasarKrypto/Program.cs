using System;

namespace CeasarKrypto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Ceasar kryptering");

            // Ange en text
            Console.Write("Ange en text: ");
            string meddelande = Console.ReadLine();

            // Ange en ntyckel att kryptera med
            Console.Write("Ange en nyckel att kryptera med: ");
            int nyckel = int.Parse(Console.ReadLine());

            // Loopa igenom bokstäverna i meddelandet
            string meddelandeKrypterad = "";
            for (int i = 0; i < meddelande.Length; i++)
            {
                // Plocka ut en bokstav
                char bokstav = meddelande[i];

                // Plocka ut teckenvärdet (ASCII)
                int ascii = (int)bokstav;

                // Mellanslag skall inte krypteras
                int asciiCeasar = ascii;
                if (ascii >= 65 && ascii <= 90)
                {
                    // Kryptera med nyckeln
                    asciiCeasar = ascii + nyckel;

                    // A-Z : 65-90
                    if (asciiCeasar >= 90)
                    {
                        asciiCeasar -= 26;
                    }
                    if (asciiCeasar <= 65)
                    {
                        asciiCeasar += 26;
                    }
                }

                // Översätt till krypterad bokstav
                char bokstavKrypterad = (char)asciiCeasar;

                // Samla in alla krypterade bokstäver
                meddelandeKrypterad += bokstavKrypterad.ToString();
            }

            // Skriv ut det färdig krypterade meddelandet
            Console.WriteLine(meddelandeKrypterad);
        }
    }
}
