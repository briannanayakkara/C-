using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
  
    class Program
    {
        
       
        static void Main(string[] args)
        {

            int drink, howmany; // laver en int for intager hvad bruger vill have 
            Console.WriteLine("vælge en drink");
            Console.WriteLine("1. Isbjørn =10kr  2. Champagnebrus =15kr 3. Tequila Sunrise =20kr 4. Mojito= 25kr 5. Brandbil =30kr 6. Filur =35kr");
            drink = Convert.ToInt32(Console.ReadLine()); // brugern intaster hvilken drink han/hun skal have
            Console.WriteLine("hvormange??");// brugern indtaster hvormange drink han /hun skal have
            howmany = Convert.ToInt32(Console.ReadLine());

            double Isbjørn = 10, Champagnebrus = 15, TequilaSunrise = 20, Mojito = 25, Brandbil = 30, Filur = 35;

            switch (drink) // laver en switch case 
            {
                case 1: // hvis brugern taster 1 så vill han gerne have Isbjørn derfor køre den kode 
                    Console.WriteLine("Isbjørn x {0}", howmany);
                    Console.WriteLine(howmany * Isbjørn+ "kr" ); // udregner hvor meget bruger skal betale 
                    break;

                case 2: // hvis brugfern taster 2 
                    Console.WriteLine("Champagnebrus x {0}", howmany);
                    Console.WriteLine(howmany * Champagnebrus + "kr");  // udregner hvor meget bruger skal betale 
                    break;

                case 3: // hvis brugfern taster 3
                    Console.WriteLine("Tequila Sunrise x {0}", howmany);
                    Console.WriteLine(howmany * TequilaSunrise + "kr");  // udregner hvor meget bruger skal betale 
                    break;

                case 4: // hvis brugfern taster 4
                    Console.WriteLine("Mojito x {0}", howmany);
                    Console.WriteLine(howmany * Mojito + "kr");  // udregner hvor meget bruger skal betale 
                    break;

                case 5: // hvis brugfern taster 5
                    Console.WriteLine("Brandbil x {0}", howmany);
                    Console.WriteLine(howmany * Brandbil + "kr");  // udregner hvor meget bruger skal betale 
                    break;

                case 6: // hvis brugfern taster 6
                    Console.WriteLine("Filur x {0}", howmany);
                    Console.WriteLine(howmany * Filur + "kr");  // udregner hvor meget bruger skal betale 
                    break;

                default: // hvis brugfern taster over 6 eller 0 so køre den kode
                    Console.WriteLine("forkert vælge");
                    break;
            }
            




            Console.ReadKey();
        }

    }
}
    