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
            string Navn = "Søren";
            double Alder = 16, Penge = 1234.34;

            Console.WriteLine("Jeg hedder {0}, er {1} år gammel og har tjent {2} kr. på at lappe cykler",Navn , Alder, Penge);

            Console.ReadKey();
        }
    }
}
