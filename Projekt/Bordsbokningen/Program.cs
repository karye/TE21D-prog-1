﻿using System;
using System.IO;

namespace Bordsbokningen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initiera några variabler
            string filnamn = "centralbord.csv";
            string tomBokning = "0, Inga gäster";
            int antalBord = 8;

            // Skapa array för att lagra bokningar
            string[] bordsInformation = new string[antalBord];

            // Information om programmet
            Console.WriteLine("Välkommen till Centralrestaurangens bordshanterare!");

            // Läs från textfilen och lagra i aen array
            if (File.Exists(filnamn))
            {
                bordsInformation = File.ReadAllLines(filnamn);
            }
            else
            {
                // Fyll filen med 8 tomma bord
                // Fyll arrayens alla platser med texten tombokning
                for (int i = 0; i < antalBord; i++)
                {
                    bordsInformation[i] = tomBokning;
                }
                // Spara ned hela arrayen i textfilen
                File.WriteAllLines(filnamn, bordsInformation);
                Console.WriteLine("Fil med bokningar hittades ej. Ny fil skapad.");
            }

            // Programloopen
            bool villAvsluta = false;
            while (!villAvsluta)
            {

                // Skriv ut menyn
                Console.WriteLine("\n1. Visa alla bord");
                Console.WriteLine("2. Boka bord");
                Console.WriteLine("3. Avboka bord");
                Console.WriteLine("4. Avsluta");
                Console.Write("Välj ett alternativ: ");
                string val = Console.ReadLine();

                // Hanterar användarens val
                int antalGäster = 0;
                int bord = 0;
                string namn = "";
                switch (val)
                {
                    case "1":
                        // Visa alla bord
                        for (int i = 0; i < antalBord; i++)
                        {
                            if (bordsInformation[i] == tomBokning)
                            {
                                // Ingen bokning
                                Console.WriteLine($"Bord {i + 1} - Inga gäster");
                            }
                            else
                            {
                                // Bokning finns
                                string rad = bordsInformation[i];

                                // Dela upp raden efter ", "
                                string[] delar = rad.Split(", ");
                                antalGäster = int.Parse(delar[0]);
                                namn = delar[1];

                                Console.WriteLine($"Bord {i + 1} - Namn: {namn}, antal gäster: {antalGäster}");
                            }
                        }
                        break;

                    case "2":
                        // Ändra bokning
                        // Vilket bord 1-8?
                        Console.Write("Ange bord (1-8): ");
                        string bordString = Console.ReadLine();

                        // Det är fel om inte heltal och < 1 eller större > 8
                        while (!int.TryParse(bordString, out bord) || (bord < 1 || bord > 8))
                        {
                            // Skriv felmeddelande
                            Console.Write("Fel! Vg välj bord 1-8: ");
                            bordString = Console.ReadLine();
                        }
                        // @TODO Vad händer om bordet är redan bokat?

                        // Vilket namn?
                        // @TODO Vad om man matar ett tomt nam?
                        Console.Write("Ange namn: ");
                        namn = Console.ReadLine();

                        // Antal gäster?
                        Console.Write("Ange antal gäster: ");

                        // @TODO Vad är max antal gäster?
                        antalGäster = 0;
                        while (!int.TryParse(Console.ReadLine(), out antalGäster))
                        {
                            // Skriv felmeddelande
                            Console.Write("Fel! Vg välj ange ett korrekt tal: ");
                        }

                        // Nu genomför vi bokningen!
                        bordsInformation[bord + 1] = antalGäster + "," + namn;

                        // Spara ned hela arrayen i textfilen
                        File.WriteAllLines(filnamn, bordsInformation);
                        Console.WriteLine("Bokningen är sparad");
                        break;

                    case "3":
                        // Ta bort bokning
                        break;

                    case "4":
                        // Avsluta
                        villAvsluta = true;
                        Console.WriteLine("Välkommen tillbaka!");
                        break;

                    default:
                        Console.WriteLine("Var vänlig välj 1-4");
                        break;
                }
            }
        }
    }
}
