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

            double money = 200.50; string IHave = "jeg har ", InThebank = "kr i banken";

            Console.Write(IHave);
            Console.Write("{0:c}", money);
            Console.Write(InThebank);
            Console.ReadKey();
        }
    }
}
