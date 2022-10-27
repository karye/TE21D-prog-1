using System;

namespace Morse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Från svenska till Morsekod!");

            // 2 tabeller: svenska alfabetet och morsealfabetet
            string alfabetet = "ABCDEFGHIJKLMNIOPQRSTUVWXYZÅÄÖ ";
            string[] morse = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", 
                              "....", "..", ".---", "-.-", ".-..", "--", "-.", 
                              "---", ".--.", "--.-", ".-.", "...", "-", ".--", 
                              "...-", ".--", "-..-", "-.--", "--..", ".--.-", 
                              ".-.-", "---.", "/"};

            // Ange ett meddelande
            Console.Write("Ange ett meddelande: ");
            string meddelande = Console.ReadLine();
            
            // Loopa igenom meddelandet
            string meddelandeMorse = "";
            foreach (var tecken in meddelande)  // tecken är en 'char'
            {
                // Ersätter till versaler
                string bokstav = tecken.ToString().ToUpper();

                // Leta efter position (index) i alfabetet
                int index = alfabetet.IndexOf(bokstav);

                //Console.WriteLine($"{bokstav} ligger på index {index}");

                // Skriv ut morsekoden
                //Console.WriteLine(morse[index]);

                // Sätt samman morsemeddelandet
                meddelandeMorse += morse[index];
            }

            // Skriv ut hela meddelandet i morsekod
            Console.WriteLine(meddelandeMorse);
        }
    }
}
