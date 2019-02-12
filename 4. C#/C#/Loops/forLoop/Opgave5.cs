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

            for (int i = 7, a = 1, b = 0; i <= 84; i = i + 7, a++, b++) // i == 7 og a == 1 men 1+1 hver loop og 7+7
            {

                Console.WriteLine("7 x {0,-2} = {1,3}", a, i); // 7 tabel med rigtig ( resultat er stillet fra 2 stilling fra højer or formuler er -2 stilling fra resulat )

            }


                Console.ReadKey();
            }
        

    }
}
    
    