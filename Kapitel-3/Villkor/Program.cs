using System;

namespace Villkor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program som berättar vad man får göra
            Console.Clear();
            Console.WriteLine("Program som berättar vad man får göra");

            // Fråga efter ålder
            Console.Write("Hur gamml är du? (heltal) ");
            int ålder = int.Parse(Console.ReadLine());
            
            // Är man äldre än 18
            if (ålder >= 18)    // 18, 19, 20, ...
            {
                Console.WriteLine("Du får ta körkort!");
            }

            // Är man äldre än 15
            if (ålder >= 15)
            {
                Console.WriteLine("Du får ta mopedkörkort!");
            }

            // Om man är yngre än 15
            if (ålder < 15)
            {
                Console.WriteLine("Sorry, du får återkomma senare!");
            }
        }
    }
}
