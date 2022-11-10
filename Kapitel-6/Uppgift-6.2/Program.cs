/* 
Skapa ett program som innehåller metoden SkrivBaklänges(string meddelande). Metoden ska skriva ut parametern meddelande baklänges. Anropa metoden minst tre gånger i ditt program.
 */
using System;

namespace Uppgift_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            SkrivBaklänges("Hello World!");
        }

        static void SkrivBaklänges(string meddelande)
        {
            for (int i = meddelande.Length - 1; i >= 0; i--)
            {
                Console.Write(meddelande[i]);;
            }
        }
    }
}
