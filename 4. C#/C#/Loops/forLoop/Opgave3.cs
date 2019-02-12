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

            for (int i = 5,a = 1; i <= 60; i= i+5, a++)
            {
                Console.Write("5x{0} =",a);
                Console.WriteLine(i);
            }


            Console.ReadKey();
        }

    }
}
    