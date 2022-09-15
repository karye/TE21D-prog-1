using System;

namespace SlumpFraga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Quiz med slumpade frågor");

            // Slumpa fram ett tal 1-3
            Random generator = new Random();
            int slumptal = generator.Next(1, 4);

            // Skriv ut slumptalet
            Console.WriteLine($"Slumptalet är {slumptal}");

            // Välj ut en fråga
            string rättSvar = "";
            switch (slumptal)
            {
                case 1:
                Console.Write("Vem vann Eurovision 2022? ");
                rättSvar = "Ukraina";
                break;

                case 2:
                Console.Write("Vad heter USA förste president? ");
                rättSvar = "Washington";
                break;

                case 3:
                Console.Write("Vad äter man gärna i Frankrike till frukost? ");
                rättSvar = "Croissant";
                break;
            }
            // Be användaren gissa
            string svar = Console.ReadLine();
            if (svar == rättSvar)
            {
                Console.WriteLine("Bra svarat!");
            }
            else
            {
                Console.WriteLine("Fel svar!");
            }
        }
    }
}
