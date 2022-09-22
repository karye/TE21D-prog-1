using System;

namespace Menyer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Ett menyprogram");

            Random generator = new Random();
            // Programloopen
            /*while (true)
            {
                Console.WriteLine("\n Välj ett av följande alternativ");
                Console.WriteLine("1. Slumpa fram ett tal 1-6");
                Console.WriteLine("2. Slumpa fram ett tal 1-100");
                Console.WriteLine("3. Avsluta");
                string val = Console.ReadLine();

                // Agera valet
                 if (val == "1")
                {
                    int slumptal = generator.Next(1, 7);
                    Console.WriteLine($"Ditt slumptal är {slumptal}");
                }
                else if (val == "2")
                {
                    int slumptal = generator.Next(1, 101);
                    Console.WriteLine($"Ditt slumptal är {slumptal}");
                }
                else if (val == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Olgitigt val, vg försök igen!");
                } 
            }*/

            // Varianten med switch
            string val = "";
            while (val != "3")
            {
                Console.WriteLine("\n Välj ett av följande alternativ");
                Console.WriteLine("1. Slumpa fram ett tal 1-6");
                Console.WriteLine("2. Slumpa fram ett tal 1-100");
                Console.WriteLine("3. Avsluta");
                val = Console.ReadLine();

                switch (val)
                {
                    case "1":
                        int slumptal = generator.Next(1, 7);
                        Console.WriteLine($"Ditt slumptal är {slumptal}");
                        break;

                    case "2":
                        slumptal = generator.Next(1, 101);
                        Console.WriteLine($"Ditt slumptal är {slumptal}");
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val, vg försök igen!");
                        break;
                }
            }
        }
    }
}
