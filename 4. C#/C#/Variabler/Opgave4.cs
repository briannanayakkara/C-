using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            double Kage = 23.56, Øl = 34.67, Pølse = 65.34;

            Console.WriteLine("Kage = "+ Kage);
            Console.WriteLine("Øl = "+ Øl);
            Console.WriteLine("Pølse = "+ Pølse);

            Console.WriteLine("I alt = "+(Kage+Øl+Pølse));
            Console.ReadKey();
        }
    }
}
