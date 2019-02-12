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
            int num1 = 1, num2 = 2, num3 = 3, result;


            //plus 

            result = num1 + num2 + num3;
            Console.WriteLine("1 + 2 + 3 = " + result);

            // minus

            result = num1 - num2 - num3;
            Console.WriteLine("1 - 2 - 3 = " + result);
           

            // multiplication

            result = num1 * num2 * num3;
            Console.WriteLine("1 * 2 * 3 = " + result);
            

            // divition

            result = num1 / num2 / num3;
            Console.WriteLine("1 / 2 / 3 = " + result);

            // presentage


            result = num1 % num2 % num3;
            Console.WriteLine("1 % 2 % 3 = " + result);

            Console.ReadKey();

        }
    }
}
