using System;

namespace Grunder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "Min terminal";
            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Hej, vad heter du?");
            string namn = Console.ReadLine();

            Console.WriteLine("Hej, du heter visst " + namn);
        }
    }
}
