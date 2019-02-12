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

            double tal1 = 42, tal2 = 64, result = tal1+tal2;

            if (result > 100)
            {
                Console.WriteLine("Summen er større end 100!.");
            }
            else if (result < 100)
            {
                Console.WriteLine("Summen er mindre end 100");
            }

            else
            {
                Console.WriteLine(" Summen er 100");
            }

            Console.ReadKey();

        }
    }
}
    