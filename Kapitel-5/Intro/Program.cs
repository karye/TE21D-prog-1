using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrayer vad är det?");

            // 1. Skapa en array med 5 länder []
            string[] länder = { "Ghana",        // index = 0
                                "Rwanda",       // index = 1
                                "Egypten",      // index = 2
                                "Ethiopien",    // index = 3
                                "Nigeria"};     // index = 4

            // Samling = array
            Console.WriteLine("Ett land i Afrika " + länder[1]);

            // Skriv 2 andra länder
            Console.WriteLine($"{länder[0]} och {länder[4]} är två länder i Afrika.");

            // 2. Skapa en tom array av heltal (int) med 10 platser
            int[] heltalen = new int[10];       // 0-9

            // Fylla en tom array
            heltalen[0] = 5;
            heltalen[1] = 15;
            heltalen[2] = 16;
            // ...
            heltalen[9] = 26;

            // Låt användaren fylla arrayen heltalen[]
            int[] åldrar = new int[10];
            for (int i = 0; i < åldrar.Length; i++)
            {
                Console.WriteLine("Ange ålder på en kompis: ");
                åldrar[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
