using System;

namespace TextHantering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Skriv en text: ");
            string svar = Console.ReadLine();
            
            // Hitta en bokstav "a"
            if (svar.Contains("a"))
            {
                Console.WriteLine("Hittade ett a");
            }

            if (svar.Contains("och"))
            {
                Console.WriteLine("Hittad \'och\' i texten!");
            }

            // Byt ut "a" med "o"
            string nyText = svar.Replace("a", "o");
            Console.WriteLine(nyText);

            // Skriv ur första bokstaven
            Console.WriteLine(svar[0]);

            // Skriv 3 första bokstäverna
            Console.WriteLine(svar[0..2]);

            // Skriv del av text, startposition och längd
            Console.WriteLine(svar.SubString(2, 2));
        }
    }
}
