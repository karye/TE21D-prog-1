using System;

namespace Datatyper
{
    class Program
    {
        static void Main(string[] args)
        {
            // Berätta om programmet
            Console.Clear();
            Console.WriteLine("Program som räknar ut ålder vid examen");

            // Läs in namnet
            Console.Write("Ange ditt namn: ");
            string namn = Console.ReadLine();
            
            // Läs in ålder
            Console.Write("Ange din ålder: ");
            string ålderString = Console.ReadLine(); // Tex "17"
            
            // Konvertera från string till heltal
            int ålder = int.Parse(ålderString); // Tex 17

            // Räkna ut ålder vid examen
            ålder = ålder + 2;

            // Skriv ut resultatet
            //Console.WriteLine(namn + ", du är " + ålder + " år när du tar examen 2024");
            Console.WriteLine($"{namn} du är {ålder} år när du tar examen 2024");
        }
    }
}
