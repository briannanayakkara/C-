using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
        

            double KmPerD;// laver en double så den kan intager desibel taller osv..
            Console.WriteLine("Reglerne for befordringsfradrag er:");
            Console.WriteLine("1. Første 24 km ingen fradrag");
            Console.WriteLine("2. 25 - 100 km 1,54kr pr km ");
            Console.WriteLine("3. Over 100 km 0,77 kr pr km");

            Console.WriteLine("Hvor meget køre du om dagen??"); // spørger brugern om hvor megel han7hun køre om dagen 
            KmPerD = Convert.ToDouble(Console.ReadLine()); // intager brugerns svare

            if (KmPerD < 25)// hvis brugern køre mindre end 25 km om dagen så ulskriver den kode 
            {
                Console.WriteLine("du få ingen fradrag");
            }

            if (KmPerD >= 25 && KmPerD <= 100)// hvis brugern køre mellem 25 og 100 km om dagen så ulskriver den kode  (har brugt &&)
            {
                Console.WriteLine("du få 1,54 kr pr km ");
            }
            if (KmPerD > 100 || 100 < KmPerD)// hvis brugern køre over 100 km om dagen så ulskriver den kode  (har brugt ||)
            {
                Console.WriteLine("du få 0,77 kr pr km");
            }
            
            Console.ReadKey();
            
        }
    }
}
