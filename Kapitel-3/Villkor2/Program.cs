using System;

namespace Villkor2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Hur gammal är du? ");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder >= 15)
            {
                // 15, 16, 17..
                Console.WriteLine("Du får ta AM-körkort");

                if (ålder >= 18)
                {
                    Console.WriteLine("Du får ta B-körkort");
                }
            }
            else
            {
                // 14, 13, 12..
                Console.WriteLine("Du får cykla");
            }
    }
}
