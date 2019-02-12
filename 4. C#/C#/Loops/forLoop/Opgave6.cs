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

            for (int i = 10, a = 1,b=0; a <= 12; i = i= i+i, a++,b++) // 10 tabel (i == 10 og a == 1) og (10+10 og 1+1) derfor intil a == 12 den kode køre på en loop
            {
 
                Console.WriteLine("10 x {0,-5} = {1,5}", a, i); // 10 tabel med rigtig ( resultat er stillet fra 5 stilling fra højer or formuler er -5 stilling fra resulat )
              
            }

                Console.ReadKey();
            }
        

    }
}
    