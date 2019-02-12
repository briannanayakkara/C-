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
           
            // chair
            Chair ch1 = new Chair();
            // setter vædier
            ch1.SetModel("Funny Chair");
            ch1.SetColor("Funny Pink");
            ch1.SetCost(100);



            // udskriv info
            ch1.PrintInfo();

            //  computer 
            Computer com1 = new Computer();
            // setter vædier
            com1.SetModel("Apple");
            com1.SetColor("jet black");
            com1.SetYear(2018);

            // udskriv info
            com1.PrintInfo();

            //

            Console.ReadKey();
        }
    }
}
