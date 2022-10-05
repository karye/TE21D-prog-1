using System;

namespace Prov1a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Program för att räkna ut lön efter skatt (nettolön)");

            // Mata in namn
            Console.Write("Vad heter du? ");
            string namn = Console.ReadLine();

            // Programloop
            while (true)
            {
                // Tvinga användaren att mata in RÄTT bruttolön 
                int bruttolön = 0;
                while (true)
                {
                    Console.Write("Ange din bruttolön (10000-45000): ");
                    bruttolön = int.Parse(Console.ReadLine());

                    // Kontrollera inmatning
                    if (bruttolön < 10000 || bruttolön > 45000)
                    {
                        Console.WriteLine("Bruttolön måste vara 10000-45000, vg försök igen!");
                    }
                    else
                    {
                        break;
                    }
                }

                // Tvinga användaren mata in RÄTT skattesats
                int skattesats = 0;
                while (true)
                {
                    // Mata in skattesats
                    Console.Write("Ange din skattesats (10%-45%): ");
                    skattesats = int.Parse(Console.ReadLine());

                    // Kontroller inmatning 2
                    if (skattesats < 10 || skattesats > 45)
                    {
                        Console.WriteLine("Skattesats måste vara 10-45, vg försök igen!");
                    }
                    else
                    {
                        break;
                    }
                }

                // Räkna ut nettolön
                int nettolön = bruttolön * (100 - skattesats) / 100;

                // Skriv nettolön
                Console.WriteLine($"{namn} din nettolön är {nettolön}");
                Console.WriteLine($"Baserat på bruttolön {bruttolön} och skattesats {skattesats}");

                // Avsluta?
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Vill du göra en till beräkning? (j/n)");
                string svar = Console.ReadLine().ToLower();
                if (svar == "n")
                {
                    break;
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
