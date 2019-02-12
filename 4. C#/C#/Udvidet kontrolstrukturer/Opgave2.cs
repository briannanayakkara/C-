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
            int i = 0, math, result; // i == hvad man ganger med or math == hvilken nummer vi ganger og result == resultat
            math = 4; // math == 4 det betyder at 4 * X

            while (i <= 12)
            {

                i++; // i++ == 0+1 
                result = math * i; // "result" er nu resultat (4 * x = resultat)
                if (result == 16) // nå resultat er == 16 so spinger den number over 
                {
                    Console.WriteLine("  "); // den viser at number 16 er spronget over 

                    continue;//spinger den number over indsted for at stop
                }
                Console.WriteLine("{0} x {1,2} = {2,2}", math, i, result); // skriver ned 4 tabbelen 
                

                if (i == 12)
                {
                    Console.WriteLine("Loopen er nu stoppet"); //  skriver "Loopen er nu stoppet" nå i == 12 det vill sige når tabbelen er slut 
                    break;// stopper 
                }
            

            }
            Console.ReadKey();
        }
    }
}
