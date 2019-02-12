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
            for (int i = 0,result = 0; i  <= 12; i++, result= 3 * i) //formuler for at laver 3 tabellen
            {
                Console.WriteLine("3 x {0} = {1,2}", i, result); // den kode vill køre først 

                if (result == 21) // når resultat blive 21 stopper loopen
                {
                    // den kode vill køre næste
                    Console.WriteLine("Loopen er nu stoppet");
                    break;// methode for at stop loopen
                 
                }

                //hvis if statment køre først så 3 tabellen vill ikke vise number 21

            }
            Console.ReadKey();
        }
    }
}
