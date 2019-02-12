using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktors
{
    class Program
    {
        static void Main(string[] args)
        {

            Bog SherlockHolmes = new Bog(150, "Sherlock Holmes");
            Bog MobyDick = new Bog("Moby Dick");
            Console.WriteLine();
            MobyDick.PrintInfo();
            Console.WriteLine();


            // SherlockHolmes
            SherlockHolmes.PrintInfo();
            if (SherlockHolmes.HarRåd(0) == true)
            {
                Console.WriteLine("Jeg har råd");
            }

            else 
            { Console.WriteLine("Jeg har ikke råd"); }
            Console.ReadKey();
            Console.WriteLine();

            // MobyDick

            MobyDick.PrintInfo();
            if (MobyDick.HarRåd(0) == true)
            {
                Console.WriteLine("Jeg har råd");
            }

            else
            { Console.WriteLine("Jeg har ikke råd"); }




            Console.ReadKey();
        }
    }
}
