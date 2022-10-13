using System;

namespace NamnOrdning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange ditt namn som Förnamn Efternamn: ");
            string namn = Console.ReadLine();

            // Trimma namn
            namn = namn.Trim();
            
            // Kontrollera att inmattat är tillräckligt långt
            if (namn.Length >= 3)
            {
                // Leta rätt på mellanslag
                int index = namn.IndexOf(" ");
                string förnamn = namn.Substring(0, index);
                string efternamn = namn.Substring(index + 1);

                // Skriv som i Frankrike
                Console.WriteLine(efternamn + " " + förnamn);
            }
            else
            {
                Console.WriteLine("Du förstod inte uppgiften");
            }
        }
    }
}
