using System;

namespace EpostKoll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Kontrollera att epost är korrekt och plocka ut delarna");

            // Mata in epost
            Console.Write("Mata in din epostadress: ");
            string epost = Console.ReadLine();
            
            // Skriver ut längden
            Console.WriteLine($"Epostadressen {epost.Length}");

            // Rensa tomma mellanslag
            epost = epost.Trim();

            // Skriver ut längden
            Console.WriteLine($"Epostadressen {epost.Length} trimmad");

            // Kontrollera formatet
            // Innehålla @-tecken, .-tecken, minst a@b.se = 6 tecken långt
            if (epost.Contains("@") && epost.Contains(".") && epost.Length >= 6)
            {
                Console.WriteLine("Din epostadress ser OK ut");

                // Plocka ut "namnet"
                int index = epost.IndexOf("@");
                Console.WriteLine($"@-tecknet finns på position {index}");

                string namn = epost.Substring(0, index);
                Console.WriteLine($"Namnet i epostadressen är {namn}");

                // Plocka ut domän
                string domän = epost.Substring(index + 1);
                Console.WriteLine($"Domänen i epostadressen är {domän}");

                // Plocka ut domänändelsen
                index = domän.IndexOf(".");
                string domänändelse = domän.Substring(index + 1);
                Console.WriteLine($"Domänändelsen är {domänändelse}");
            }
            else
            {
                Console.WriteLine("Din epostadress ser felaktig ut");
            }
        }
    }
}
