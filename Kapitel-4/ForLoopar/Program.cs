using System;

namespace ForLoopar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Slumpa och gissa 5ggr!");

            // Skapa ett slumptal 1-00
            Random generator = new Random();
            int slumptal = generator.Next(1, 101);

            // Loopa 5 ggr
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Gissa ett tal 1-100: ");
                int gissning = int.Parse(Console.ReadLine());

                if (gissning == slumptal)
                {
                    Console.WriteLine("Bravo du gissade rätt!");
                    break;
                }
                else
                {
                    Console.WriteLine(i + " Fel svar, försök igen! ");
                }
            }
        }
    }
}
