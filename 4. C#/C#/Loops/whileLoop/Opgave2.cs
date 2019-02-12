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
            int i = 100; 

            while (i >= 1)  // i == 100 og i er store end 1 (den kode køre intid i == 1) 
            {
                Console.WriteLine(i); 
                i--; // 100 - 1 = 99
            }


            Console.ReadKey();
        }

    }
}
    