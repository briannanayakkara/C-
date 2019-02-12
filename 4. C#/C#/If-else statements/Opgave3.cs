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

            double old;

            Console.WriteLine("hvor gammel er du ??");

            old = Convert.ToDouble(Console.ReadLine());

            if (old > 60)
            {
                Console.WriteLine("Du er for gammel");
            }
            else if (old < 50)
            {
                Console.WriteLine("  Du er for ung. ");
            }

            else
            {
                Console.WriteLine(" Du er hverken for gammel eller for ung");
            }
            Console.ReadKey();
        }

    }
}
    