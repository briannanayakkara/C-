using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Double answer1 = 2 + 1 * 2, answer2 = (2 + 1) * 2, answer3 = 5 / 2, answer4 = 8 % 3, answer5 = 1 - 5;

            Console.WriteLine("2 + 1 * 2  = "+ answer1);
            Console.WriteLine("(2 + 1) * 2 = " + answer2);
            Console.WriteLine("5 / 2 = "+ answer3);
            Console.WriteLine("8 % 3 = "+ answer4);
            Console.WriteLine("1 – 5= "+ answer5);

            Console.ReadKey();
        }
    }
}
