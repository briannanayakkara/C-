using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lav et array med 6 valgfrie værdier
            double[] num = { 6, 5, 4, 3, 2, 1, 0 };

            // udskriv 6 valgfrie værdier at bruge en for-løkke.
            for (int i = 0; i < num.Length ; i++)
            {
                
                Console.WriteLine(num[i]);
            }
            // Lav et string array og sæt 5 strings i. 
            string[] names = { "Kurukula ", "Arachige ", "Don ", "Dimal ", "Brian " };

            // udskriv 5 valgfrie værdier at bruge en for-løkke.
            Console.WriteLine(  ); // laver en linje mellemrum 
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i]);
            }

            Console.ReadKey();
        }
    }
}
