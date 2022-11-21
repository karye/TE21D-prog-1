using System;
using J3QQ4;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Hello Snake! ");

            Console.WriteLine(Emoji.Snake + Emoji.Alien);

            // Virtuell rad
            int[] raden = { 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 };
            int vitPos = 3;

            while (true)
            {
                // Töm vita rutan
                raden[vitPos] = 0;

                // Läs in en tangent
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.A)
                {
                    vitPos--;
                }
                else if (key.Key == ConsoleKey.D)
                {
                    vitPos++;
                }

                // Rita nya positionen på vita rutan
                raden[vitPos] = 1;

                // Rita ut virtuella raden
                Console.Clear();
                for (int i = 0; i < raden.Length; i++)
                {
                    if (raden[i] == 0)
                    {
                        Console.Write(Emoji.Black_Large_Square);
                    }
                    else
                    {
                        Console.Write(Emoji.White_Large_Square);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
