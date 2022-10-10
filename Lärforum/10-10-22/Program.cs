using System;

namespace _10_10_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            /*             Console.WriteLine("BMI kalkylator");

                        // Programloop
                        while (true)
                        {
                            // Ange vikt i kg (double)
                            Console.Write("Ange vikt i kg: ");
                            double vikt = double.Parse(Console.ReadLine());

                            // Ange längd i m (double)
                            Console.Write("Ange längd i m: ");
                            double längd = double.Parse(Console.ReadLine());

                            // Räkna ut BMI
                            double bmi = vikt / (längd * längd);
                            Console.WriteLine($"Din BMI är {bmi}");

                            // Onaturligt underviktig	0 – 14,9
                            if (bmi <= 14.9)
                            {
                                Console.WriteLine("Onaturligt underviktig	0 – 14,9");
                            }
                            // Betydligt underviktig	15 – 17,9
                            else if (bmi <= 17.9)
                            {
                                Console.WriteLine("Betydligt underviktig	15 – 17,9");
                            }
                            // Aningen underviktig	18 – 18,9
                            else if (bmi <= 18.9)
                            {
                                Console.WriteLine("Aningen underviktig	18 – 18,9");
                            }
                            // Normal vikt	19 – 24,9
                            else if (bmi <= 24.9)
                            {
                                Console.WriteLine("Normal vikt	19 – 24,9");
                            }
                            // 25+
                            else
                            {
                                Console.WriteLine("Du är bra!");
                            }

                            Console.Write("Vill du köra igen? (j/n)");
                            string svar = Console.ReadLine();
                            if (svar == "j")
                            {
                                Console.WriteLine("Trevligt, du vill räkna igen!");
                            }
                            else
                            {
                                break;
                            }
                        } */

            /* 
            Skapa ett program som frågar användaren hur många datorer hen äger. Programmet ska sedan skriva ut hur många datorer hen äger med ett ord som är korrekt i singular eller plural. Det innebär att om användaren har en dator ska programmet skriva ut
            Du har 1 dator.
            Om användaren har t.ex. 3 datorer ska programmet skriva ut
            Du har 3 datorer.
            Bestäm om ordet dator/datorer ska användas med hjälp av villkorsoperatorn.
             */

            Console.WriteLine("Hur många gånger vill snurra? ");
            int antalLoopar = int.Parse(Console.ReadLine());

            for (int i = 0; i < antalLoopar; i++)
            {
                // Hur många datorer har du?
                Console.Write("Hur många datorer har du? ");
                int antal = int.Parse(Console.ReadLine());

                if (antal == 1)
                {
                    Console.WriteLine("Du har en dator.");
                }
                else if (antal > 1)
                {
                    Console.WriteLine($"Du har {antal} datorer.");
                    Console.WriteLine("Du har " + antal + " datorer.");
                }
                else
                {
                    Console.WriteLine("Du måste spara lite pengar!");
                }
            }
        }
    }
}
