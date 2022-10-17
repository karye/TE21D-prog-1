using System;

namespace Årtal
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Skapa ett program som innehåller en array med minst 5 årtal, minst ett av årtalen ska finnas med två gånger. Användaren ska få skriva in ett årtal när programmet körs. Programmet ska skriva ut alla index som detta årtal finns på i arrayen. Om årtalet inte fanns på någon plats så ska programmet skriva "Årtalet kunde inte hittas". */
            Console.WriteLine("Årtal!");

            // Skapa en array med minst 5 årtal, minst ett av årtalen ska finnas med två gånger. (hårdkoda)
            string[] årtal = { "1992", "2000", "1992", "2020", "2050" };

            // Användaren ska få skriva in ett årtal
            Console.Write("Ange ett årtal: ");
            string sökÅrtal = Console.ReadLine();

            // Programmet ska skriva ut alla index som detta årtal finns på i arrayen.
            // Om årtalet inte fanns på någon plats så ska programmet skriva "Årtalet kunde inte hittas".
            bool hittad = false;
            for (int i = 0; i < årtal.Length; i++)
            {
                // Kolla om lika med sökÅrtal 
                if (årtal[i] == sökÅrtal)
                {
                    Console.WriteLine(i);
                    hittad = true;
                }
            }
            if (!hittad)
            {
                Console.WriteLine("Årtalet kunde inte hittas");
            }
        }
    }
}
