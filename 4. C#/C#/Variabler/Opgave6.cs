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
            double radius, areal;
            Console.WriteLine("intaste radius og tryk enter...");
            radius = Convert.ToDouble(Console.ReadLine());
            areal = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Areal = "+ areal);
            Console.ReadKey();
        }
    }
}
