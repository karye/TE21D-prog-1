using System;

namespace IpKoll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in en IP-adressen: ");
            string ipAdress = Console.ReadLine();
            
            ipAdress = ipAdress.Trim();

            // Kolla längden
            if (ipAdress.Length == 15)
            {
                // Leta rätt på första punkten
                int index1 = ipAdress.IndexOf(".");
                string del1 = ipAdress.Substring(0, index1);
                Console.WriteLine(del1);

                // Leta rätt på nästa punkt
                int index2 = ipAdress.IndexOf(".", index1);
                string del2 = ipAdress.Substring(index1 + 1, index2);
                Console.WriteLine(del2);
            }
            else
            {
                Console.WriteLine("Fel format");
            }
        }
    }
}
