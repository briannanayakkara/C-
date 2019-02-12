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
            int var1 = 1, var2 =2;

            bool tf = var1 > var2;

            Console.WriteLine(tf);

        
            var1 = 2; var2 = 1;

            tf = var1 > var2;
            Console.WriteLine(tf);
            Console.ReadKey();

        }
    }
}
