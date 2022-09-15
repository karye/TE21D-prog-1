using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Ett quiz program!");
            int poäng = 0;

            Console.Write("Vad heter Sveriges största sjö? ");
            string svar = Console.ReadLine();
            
            // Fråga1 - Är svaret Vänern?
            if (svar == "Vänern")
            {
                Console.WriteLine("Bra svarat!");
                poäng++;    // +1
            }
            else
            {
                Console.WriteLine("Fel svar!");
            }

            // Fråga 2 - 
            Console.Write("Vad heter Sveriges närmsta Berg ");
            svar = Console.ReadLine();
            
            if (svar == "Hammarbybacken")
            {
                Console.WriteLine("Yes!");
                poäng++; // +1
            }
            else
            {
                Console.WriteLine("Njet!");
            }

            Console.WriteLine("Du har " + poäng);
        }
    }
}
