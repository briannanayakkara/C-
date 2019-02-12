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
            for (int i = 100; i >= 1; i--) // i == 100 og i er store end 1 og 100-1 = 99 (den kode køre intid i == 1) 
            {
                Console.WriteLine(i); // den kode vill køre ige og igen intid i == 1
            }

            Console.ReadKey();
        }

    }
}
    