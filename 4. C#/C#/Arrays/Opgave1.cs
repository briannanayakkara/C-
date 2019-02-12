using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //  Lav et array med  {}.
            int[] num = { -2, -1, 0, 10 };

            // Lav et array med  new int[x]. 
            int[] num1 = new int[4];

            num1[0] = -2;
            num1[1] = -1;
            num1[2] = 0;
            num1[3] = 10;

            //  Udskriv elementet 10 og -1 
            Console.WriteLine("num array");
            Console.WriteLine();
            Console.WriteLine("{0} og {1} ",num[1], num[3]);
            Console.WriteLine();
            //  Udskriv elementet 10 og -1 
            Console.WriteLine("num1 array");
            Console.WriteLine();
            Console.WriteLine("{0} og {1} ", num1[1], num1[3]);
            // Udskriv summen af alle elementerne
            Console.WriteLine("summen af alle elementerne i num array");
            int sum = num[0] + num[1] + num[2] + num[3];
            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
